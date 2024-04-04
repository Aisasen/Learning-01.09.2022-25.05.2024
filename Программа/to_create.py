import tkinter as tk
from tkinter import simpledialog, messagebox, filedialog
import json
from cryptography.fernet import Fernet

class TestCreatorApp:
    def __init__(self, master):
        self.master = master
        self.master.title("Создание тестов")

        self.question_label = tk.Label(master, text="Введите вопрос:")
        self.question_label.pack()

        self.question_entry = tk.Entry(master, width=50)
        self.question_entry.pack()

        self.question_label = tk.Label(master, text="Введите ответ:")
        self.question_label.pack() 
        self.answers_frame = tk.Frame(master)
        self.answers_frame.pack()
        self.add_answer_button = tk.Button(master, text="Добавить ответ", command=self.add_answer)
        self.add_answer_button.pack()

        self.save_button = tk.Button(master, text="Сохранить вопрос", command=self.save_question)
        self.save_button.pack()

        self.save_to_file_button = tk.Button(master, text="Сохранить в файл", command=self.save_to_file)
        self.save_to_file_button.pack()

        self.edit_button = tk.Button(master, text="Редактировать тест", command=self.edit_test)
        self.edit_button.pack()
        self.answer_count = 0

        self.questions = []

        # Загрузка ключа шифрования из файла
        with open('key.txt', 'rb') as file:
            self.key = file.read()

        # Создание объекта Fernet для шифрования/дешифрования
        self.cipher = Fernet(self.key)

    def add_answer(self):
        self.answer_count += 1
        answer_text = f"Ответ {self.answer_count}: "
        
        answer_label = tk.Label(self.answers_frame, text=answer_text)
        answer_label.pack(side="top")
        answer_entry = tk.Entry(self.answers_frame, width=50)
        answer_entry.pack(side="top")
        
        self.answers_frame.update_idletasks()

    def add_answer(self):
        self.answer_count += 1
        answer_text = f"Ответ {self.answer_count}: "
        
        answer_label = tk.Label(self.answers_frame, text=answer_text)
        answer_label.pack(side="top")
        answer_entry = tk.Entry(self.answers_frame, width=50)
        answer_entry.pack(side="top")
        
        self.answers_frame.update_idletasks()

    def save_question(self):
        self.answer_count = 0
        question = self.question_entry.get()
        answers = [child.get() for child in self.answers_frame.winfo_children() if isinstance(child, tk.Entry)]
        correct_answer_index = None

        if question and answers:
            correct_answer_index = simpledialog.askinteger("Правильный ответ", "Введите номер правильного ответа (начиная с 1):")
            
            if correct_answer_index is None or correct_answer_index < 1 or correct_answer_index > len(answers):
                messagebox.showerror("Ошибка", "Пожалуйста, введите правильный номер ответа.")
                return

            correct_answer_index -= 1

            self.questions.append({"question": question, "answers": answers, "correct_answer_index": correct_answer_index})
            self.question_entry.delete(0, tk.END)
            
            # Удаление меток с ответами и соответствующих им элементов Entry
            for child in self.answers_frame.winfo_children():
                child.destroy()
            
            messagebox.showinfo("Успешно", "Вопрос успешно сохранен!")
        else:
            messagebox.showerror("Ошибка", "Пожалуйста, введите вопрос и хотя бы один ответ.")




    def save_to_file(self):
        filename = filedialog.asksaveasfilename(defaultextension=".enc", filetypes=[("Encrypted JSON files", "*.enc")])
        if filename:
            with open(filename, 'wb') as file:
                # Шифруем данные перед сохранением
                encrypted_data = self.cipher.encrypt(json.dumps(self.questions).encode())
                file.write(encrypted_data)
                messagebox.showinfo("Успешно", f"Тест сохранен в {filename}")

    def edit_test(self):
        filename = filedialog.askopenfilename(filetypes=[("Encrypted JSON files", "*.enc")])
        if filename:
            with open(filename, 'rb') as file:
                # Дешифруем данные после чтения из файла
                encrypted_data = file.read()
                decrypted_data = self.cipher.decrypt(encrypted_data).decode()
                self.questions = json.loads(decrypted_data)
            self.show_edit_dialog()

    def show_edit_dialog(self):
        self.edit_window = tk.Toplevel(self.master)
        self.edit_window.title("Редактирование теста")

        self.current_question_index = 0
        self.create_button_frame()  # Создаем фрейм для кнопок
        self.display_question()

    def create_button_frame(self):
        self.button_frame = tk.Frame(self.edit_window)
        self.button_frame.pack()

        next_button = tk.Button(self.button_frame, text="Далее", command=self.next_question)
        next_button.pack(side="right")

        prev_button = tk.Button(self.button_frame, text="Назад", command=self.previous_question)
        prev_button.pack(side="right")

        delete_button = tk.Button(self.button_frame, text="Удалить вопрос", command=self.delete_question)
        delete_button.pack(side="left")

        save_button = tk.Button(self.button_frame, text="Сохранить изменения", command=self.save_changes)
        save_button.pack(side="left")

    def next_question(self):
        if self.current_question_index < len(self.questions) - 1:
            self.current_question_index += 1
            self.display_question()

    def previous_question(self):
        if self.current_question_index > 0:
            self.current_question_index -= 1
            self.display_question()

    def delete_question(self):
        del self.questions[self.current_question_index]
        if self.current_question_index >= len(self.questions):
            self.current_question_index -= 1
        if self.current_question_index < 0:
            self.current_question_index = 0
        self.display_question()

    def display_question(self):
        for widget in self.answers_frame.winfo_children():
            widget.destroy()

        question_text = self.questions[self.current_question_index]["question"]
        self.question_entry.delete(0, tk.END)
        self.question_entry.insert(0, question_text)

        answers = self.questions[self.current_question_index]["answers"]
        for answer in answers:
            answer_entry = tk.Entry(self.answers_frame, width=50)
            answer_entry.insert(0, answer)
            answer_entry.pack()

    def save_changes(self):
        question = self.question_entry.get()
        answers = [child.get() for child in self.answers_frame.winfo_children()]
        correct_answer_index = simpledialog.askinteger("Правильный ответ", "Введите номер правильного ответа (начиная с 1):")

        if correct_answer_index is None:  # Если нажата кнопка "Отмена"
            return

        if not 1 <= correct_answer_index <= len(answers):
            messagebox.showerror("Ошибка", "Пожалуйста, введите правильный номер ответа.")
            return

        correct_answer_index -= 1

        if correct_answer_index == self.questions[self.current_question_index]["correct_answer_index"]:
            messagebox.showerror("Ошибка", "Изменения не внесены.")
            return

        self.questions[self.current_question_index]["question"] = question
        self.questions[self.current_question_index]["answers"] = answers
        self.questions[self.current_question_index]["correct_answer_index"] = correct_answer_index

        messagebox.showinfo("Успешно", "Тест успешно отредактирован!")

def main():
    root = tk.Tk()
    app = TestCreatorApp(root)
    
    root.mainloop()

if __name__ == "__main__":
    main()
