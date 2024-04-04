import tkinter as tk
from tkinter import simpledialog, messagebox, filedialog
import subprocess

exe_path_solve = 'solve.exe'
exe_path_to_create = 'to_create.exe'

class TestCreatorApp:
    def __init__(self, master):
        self.add_answer_button = tk.Button(master, text="Решить тест", command=self.solve)
        self.add_answer_button.pack()

        self.save_button = tk.Button(master, text="Создать тест", command=self.to_create)
        self.save_button.pack()

    def solve(self):
        try:
            subprocess.run([exe_path_solve])
        except FileNotFoundError:
            print("Файл не найден. Убедитесь, что путь к файлу верный.")
        except Exception as e:
            print(f"Произошла ошибка: {e}")

    def to_create(self):
        try:
            subprocess.run([exe_path_to_create])
        except FileNotFoundError:
            print("Файл не найден. Убедитесь, что путь к файлу верный.")
        except Exception as e:
            print(f"Произошла ошибка: {e}")

def main():
    root = tk.Tk()
    app = TestCreatorApp(root)
    root.geometry("200x200")  
    root.mainloop()



if __name__ == "__main__":
    main()
