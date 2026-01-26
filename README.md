# Address Book System
This repository contains the **Address Book System** project developed as part of the BridgeLabz fellowship. The system demonstrates the application of C# programming, Object-Oriented concepts, Collections, File IO, and advanced data handling to manage personal contacts efficiently.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio / VS Code
- **Version Control:** Git & GitHub

---

## ✨ Features
- **CRUD Operations:** Create, Read, Update, and Delete contacts.
- **Data Integrity:** Prevents duplicate entries using collection methods and overrides.
- **Search & Filter:** Search or view persons globally across multiple address books by City or State.
- **Advanced Sorting:** Sort entries alphabetically by Name, or by City, State, and Zip code.
- **File Persistence:** Read and write data using File IO, CSV, and JSON formats.
- **Scalability:** Supports multiple address books managed through Dictionaries.

---

## 📂 Branch Structure

### 🔹 `master`
The main branch containing the base `Address BookMain` class and the initial program structure.

### 🔹 `uc1_create-contact`
[cite_start]Initial ability to create a Contact in the Address Book with details: First/Last Names, Address, City, State, Zip, Phone, and Email. [cite: 13, 14, 15]

### 🔹 `uc2_add_contact`
[cite_start]Implementation of adding new contacts via the Console and using OOP concepts to manage the relationship between the AddressBook and Contact Person. [cite: 22, 23, 24]

### 🔹 `uc3_edit_contact`
[cite_start]Ability to edit existing contact details by searching for the person using their name through the Console. [cite: 26, 27, 28]

### 🔹 `uc4_delete_contact`
[cite_start]Feature to delete a specific person from the address book using their name. [cite: 31, 32]

### 🔹 `uc5_add-multiple-contact`
[cite_start]Refactored to allow adding multiple persons one at a time using C# Collection classes to maintain the list of contacts. [cite: 34, 35]

### 🔹 `uc6_add_mutiple_address_book`
Expanded the system to support multiple unique Address Books. [cite_start]Utilizes a `Dictionary` to map unique Address Book names to their respective instances. [cite: 37, 39, 41]

### 🔹 `uc7-prevent-duplicate-contacts`
[cite_start]Ensures no duplicate entries of the same person exist in a particular Address Book by overriding the `equals` method and using collection search methods. [cite: 43, 44, 46]

### 🔹 `uc8-search_person_by_city_state`
[cite_start]Ability to search for persons across all Address Books based on a specific City or State. [cite: 48, 49]

### 🔹 `uc9_view_person_by_location`
[cite_start]Maintains a Dictionary of City/State to Persons to allow efficient viewing of all contacts belonging to a specific location. [cite: 52, 54, 55]

### 🔹 `uc10_count_by_city_state`
[cite_start]Ability to get the total count of contact persons categorized by City or State. [cite: 58, 59]

### 🔹 `uc11_sort_by_name`
[cite_start]Implemented sorting logic to display address book entries alphabetically by the Person's name using the Collection Library. [cite: 61, 63]

### 🔹 `uc12_sort_by_city_state_zip`
[cite_start]Advanced sorting features to organize entries based on City, State, or Zip code. [cite: 66, 67]

---

## 🎯 Learning Outcomes
- [cite_start]Mastered **Object-Oriented Programming** (Encapsulation, Overriding). [cite: 24, 46]
- [cite_start]Proficient use of **Generic Collections** (List, Dictionary) and **LINQ** for data manipulation. [cite: 35, 41, 63]
- [cite_start]Implementation of **File IO** to persist data across sessions. [cite: 71, 72]
- [cite_start]Understanding of **Code Hygiene**, naming conventions, and branch-wise Git workflow. [cite: 18, 19]

---

## 👤 Author
**Lucky Goyal** B.Tech CSE (Artificial Intelligence and Machine Learning)