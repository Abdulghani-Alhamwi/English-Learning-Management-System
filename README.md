# 📘 English Learning Management System

**English Learning Management System** is a desktop application built using **C# WinForms (.NET Framework 4.8.1)**. The project focuses on helping users **learn, manage, and practice English vocabulary** with Arabic translations and audio pronunciation.

---

## 🚀 Project Overview :

The application starts with a **splash screen** displaying a progress bar and initialization status, followed by the main interface where users can manage vocabulary and access learning presentation modes.

The project emphasizes :

* Clean architecture.
* Shared logic.
* Reusable components.

This approach reduces code duplication and simplifies long-term maintenance.

---

## ✨ Features :

### 🗄️ Storage System

* **File system–based storage** is used to persist English words and their Arabic translations locally.

### 📌 Core Features :

1. Splash screen with progress bar and initialization message.
2. Add English words.
3. Each word supports **up to 4 Arabic translations**.
4. English pronunciation with configurable voice.
5. System sound control via **TrackBar**.
6. **ListView** with Context Menu:

   * Change view mode.
   * Edit word.
   * Delete single word.
   * Delete multiple selected words.
   * Delete all words.

---

## 🎓 Learning / Presentation Mode :

1. Select **1–4 words**.
2. Add English example sentences.
3. Add Arabic translations for each example.
4. Automatic presentation including:

   * Word pronunciation.
   * Translation display.
   * Example pronunciation.

---

## 🖥️ Display Options for the Presentation Mode :

* Desktop **full-screen mode**.
* **Mobile-size simulation** form.

⚠️ Responsive behavior is **not implemented in this version** and is planned as a future enhancement.

---

## 🧠 Architecture & Code Quality :

* Centralized reusable methods.
* No duplicated business logic.
* Designed for maintainability and scalability.

---

## 🛠️ Technologies :

* **C#**.
* **WinForms**.
* **.NET Framework 4.8.1**.
* **Visual Studio 2026**.

---

## ▶️ How to Run :

> ⚠️ Requires **Visual Studio 2026**.

1. Clone or download the repository.
2. Edit your **Display Scale To : 100 ** to ensure everything being shown in a proper size because responsive is not added yet at this version.
3. Open the solution in **Visual Studio 2026**.
4. Ensure **.NET Framework 4.8.1** is installed.
5. Press **F5** to run.

---

## 🔮 Future Enhancements :

1. Migrate storage from file system to **relational database**.
2. Add responsive UI support.
3. Implement learning progress tracking and analytics.
