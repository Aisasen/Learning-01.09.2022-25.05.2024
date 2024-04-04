import tkinter as tk
from tkinter import filedialog, messagebox
from tkinter import ttk
import json
from cryptography.fernet import Fernet

class TestSolverApp:
    def __init__(self, master):
        self.master = master
        self.master.title("Решатель тестов")

        self.load_button = tk.Button(master, text="Загрузить тест", command=self.load_test)
        self.load_button.pack()

        self.questions = []

    def load_test(self):
        filename = filedialog.askopenfilename(filetypes=[("Encrypted JSON files", "*.enc")])
        if filename:
            # Загрузка ключа из файла
            with open('key.txt', 'rb') as file:
                key = file.read()

            # Создание объекта Fernet для дешифрования
            cipher = Fernet(key)

            with open(filename, 'rb') as file:
                # Дешифрование данных перед загрузкой
                encrypted_data = file.read()
                decrypted_data = cipher.decrypt(encrypted_data).decode()
                self.questions = json.loads(decrypted_data)

            messagebox.showinfo("Успех", "Тест успешно загружен!")
            self.start_test()

            # Скрытие кнопки загрузки теста после успешной загрузки
            self.load_button.pack_forget()

    def start_test(self):
        if self.questions:
            self.current_question_index = 0
            self.correct_answers = 0
            self.total_questions = len(self.questions)
            self.display_question()
        else:
            messagebox.showerror("Ошибка", "Нет загруженного теста!")

    def display_question(self):
        question_data = self.questions[self.current_question_index]
        question_text = question_data["question"]
        answers = question_data["answers"]

        self.question_label = tk.Label(self.master, text=question_text)
        self.question_label.pack()

        self.answer_combobox = ttk.Combobox(self.master, values=answers)
        self.answer_combobox.pack()

        self.submit_button = tk.Button(self.master, text="Отправить ответ", command=self.submit_answer)
        self.submit_button.pack()

    def submit_answer(self):
        selected_answer = self.answer_combobox.get()
        correct_answer_index = self.questions[self.current_question_index]["correct_answer_index"]
        correct_answer = self.questions[self.current_question_index]["answers"][correct_answer_index]

        if selected_answer == correct_answer:
            self.correct_answers += 1

        self.current_question_index += 1
        if self.current_question_index < len(self.questions):
            self.refresh_ui()
        else:
            percentage = (self.correct_answers / self.total_questions) * 100
            messagebox.showinfo("Конец теста", f"Вы завершили тест!\nВаш результат: {self.correct_answers}/{self.total_questions} ({percentage:.2f}%)")
            self.master.destroy()  # Закрываем окно после завершения теста


    def refresh_ui(self):
        self.question_label.destroy()
        self.answer_combobox.destroy()
        self.submit_button.destroy()
        for widget in self.master.winfo_children():
            if widget != self.load_button:
                widget.destroy()
        self.display_question()

def main():
    root = tk.Tk()
    app = TestSolverApp(root)
    root.geometry("200x200")  
    root.mainloop()

if __name__ == "__main__":
    main()
