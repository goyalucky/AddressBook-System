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
The main branch containing the base `Address BookMain` class and the initial program structure. which contains a message Welcome to Address Book System

### 🔹 `uc1_create-contact`
Initial ability to create a Contact in the Address Book with details: First/Last Names, Address, City, State, Zip, Phone, and Email. 

### 🔹 `uc2_add_contact`
Implementation of adding new contacts via the Console and using OOP concepts to manage the relationship between the AddressBook and Contact Person.

### 🔹 `uc3_edit_contact`
Ability to edit existing contact details by searching for the person using their name through the Console. 

### 🔹 `uc4_delete_contact`
Feature to delete a specific person from the address book using their name. [cite: 31, 32]

### 🔹 `uc5_add-multiple-contact`
Refactored to allow adding multiple persons one at a time using C# Collection classes to maintain the list of contacts.

### 🔹 `uc6_add_mutiple_address_book`
Expanded the system to support multiple unique Address Books. Utilizes a `Dictionary` to map unique Address Book names to their respective instances.

### 🔹 `uc7-prevent-duplicate-contacts`
Ensures no duplicate entries of the same person exist in a particular Address Book by overriding the `equals` method and using collection search methods.

### 🔹 `uc8-search_person_by_city_state`
Ability to search for persons across all Address Books based on a specific City or State.

### 🔹 `uc9_view_person_by_location`
Maintains a Dictionary of City/State to Persons to allow efficient viewing of all contacts belonging to a specific location.

### 🔹 `uc10_count_by_city_state`
Ability to get the total count of contact persons categorized by City or State.

### 🔹 `uc11_sort_by_name`
Implemented sorting logic to display address book entries alphabetically by the Person's name using the Collection Library.

### 🔹 `uc12_sort_by_city_state_zip`
Advanced sorting features to organize entries based on City, State, or Zip code.

---

## 🎯 Learning Outcomes
- Mastered **Object-Oriented Programming** (Encapsulation, Overriding). [cite: 24, 46]
- Proficient use of **Generic Collections** (List, Dictionary) and **LINQ** for data manipulation. [cite: 35, 41, 63]
- Implementation of **File IO** to persist data across sessions. [cite: 71, 72]
- Understanding of **Code Hygiene**, naming conventions, and branch-wise Git workflow. [cite: 18, 19]

---

## 👤 Author
**Lucky Goyal**  
B.Tech CSE (Artificial Intelligence and Machine Learning)
