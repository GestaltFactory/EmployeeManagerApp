# EmployeeManagerApp
EmployeeManagerApp is a Windows Forms application developed in C#. It is designed to manage employee records, their assigned tasks, and user access in a small to medium-sized organization. The application supports creating, editing, and viewing employees and tasks through a user-friendly interface, while enforcing simple access control through a login system.

Features
    User authentication via a login form
    Role-based UI: accessible menus depending on login state
    Create, edit, and delete employee profiles
    Assign tasks to employees with due dates and editing capabilities
    Separated layers for business logic, validation, and UI
    Data persistence through local file-based storage (likely JSON, XML, or flat files)

How to Run
    Open the solution file EmployeeManagerApp.sln in Visual Studio.
    Set the EmployeeManager project as the Startup Project.
    Build and run the project (F5).
    The application will start on the login screen (LoginForm). Use predefined test accounts (if any), or create one if account creation is enabled.

Notes
    The app uses a layered structure, separating the UI (GUI), data (data), and validation logic (Validation).
    Data is likely stored locally in serialized format (based on the presence of a data folder).
    Assets and icons used in the UI are stored under assets/.

For login
Admin => karl/Karl123!

<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/01.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/02.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/03.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/04.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/05.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/06.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/07.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/08.PNG" width="45%">
</p>
<p align="center">
  <img src="https://github.com/GestaltFactory/EmployeeManagerApp/blob/main/09.PNG" width="45%">
</p>
