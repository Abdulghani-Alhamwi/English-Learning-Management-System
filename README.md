# 📘 English Learning Management System

**English Learning Management System** is a desktop application built using **C# WinForms (.NET Framework 4.8.1)**. The project helps users **learn, manage, and practice English vocabulary** with Arabic translations and audio pronunciation.

The latest version integrates **AI-powered automatic example generation**, providing **English example sentences** and **Arabic translations** for selected words.

---

## 🚀 Project Overview

The application starts with a **splash screen** showing progress and initialization, then opens the main interface where users can manage vocabulary and access learning presentation modes.

The project emphasizes:

* Clean architecture
* Shared logic
* Reusable components

This reduces code duplication and simplifies long-term maintenance.

---

## ✨ Features

### 🗄️ Storage System

* **File system–based storage** persists English words and their Arabic translations locally.

### 📌 Core Features

1. Splash screen with progress bar and initialization message.
2. Add English words.
3. Each word supports **up to 4 Arabic translations**.
4. English pronunciation with configurable voice.
5. System sound control via **TrackBar**.
6. **ListView** with Context Menu:

   * Change view mode
   * Edit word
   * Delete single word
   * Delete multiple selected words
   * Delete all words

### 🤖 AI Integration Feature

* Automatically generates **English example sentences** for selected words.
* Generates **Arabic translations** of those examples using the word’s existing translations.
* Uses **Google AI Studio API** to generate examples.
* The API is **free with daily usage limits**.
* To use AI, place your API key as a string in `clsWord`:

```csharp
internal static string apiKey = "YOUR_GOOGLE_AI_KEY";
```

* AI ensures the English example uses the target word and Arabic translation uses only provided options.

---

## 🎓 Learning / Presentation Mode

1. Select **1–4 words**.
2. Generate English example sentences (manually or via AI).
3. Generate Arabic translations for each example (manually or via AI).
4. Automatic presentation includes:

   * Word pronunciation
   * Translation display
   * Example pronunciation

---

## 🖥️ Display Options

* Desktop **full-screen mode**
* **Mobile-size simulation** form

⚠️ Responsive behavior is **not implemented** in this version.

---

## 🧠 Architecture & Code Quality

* Centralized reusable methods
* No duplicated business logic
* Designed for maintainability and scalability

---

## 🛠️ Technologies

* **C#**
* **WinForms**
* **.NET Framework 4.8.1**
* **Visual Studio 2026**

---

## ▶️ How to Run

> ⚠️ Requires **Visual Studio 2026**

1. Clone or download the repository.
2. Ensure your **Display Scale** is set to 100 for proper UI display.
3. Open the solution in **Visual Studio 2026**.
4. Ensure **.NET Framework 4.8.1** is installed.
5. Set your **Google AI API key** in `clsWord`:

```csharp
internal static string apiKey = "YOUR_GOOGLE_AI_KEY";
```

> The API key is free from **Google AI Studio** but has daily usage limits.

6. Press **F5** to run.

---

## 🔮 Future Enhancements

1. Migrate storage from file system to **relational database**
2. Add responsive UI support
3. Implement learning progress tracking and analytics
4. Expand AI integration for **batch example generation**
5. Enhance sentence quality and strict adherence to Arabic translations provided
