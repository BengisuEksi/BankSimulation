### Bank Simulation

This project is a bank simulation application developed using C# and SQL. It allows users to manage their accounts, perform money transfers, and view transaction history through a user-friendly interface.

Features
1. Sign In Screen
- User Login: Users sign in using their registered account numbers and passwords.
- New Account: Users without an account can create one by selecting the "Don't have an account? Sign up!" option.
2. New Account Screen
- Users enter their first name, last name, phone number, national ID number, and password.
- After clicking the save button, the system assigns a 6-character account number to the user.
- Upon clicking the exit button, users are redirected to the sign in screen.
3. Home Page
- Make a New Transfer: Opens a screen for users to perform money transfers.
- View Transfer History: Displays a list of the user’s past transactions.
- Bank Balance: Automatically shows the user's bank balance on the screen.
- My Account: Opens a screen where users can update their account information or delete their account.
- Sign Out: Logs the user out and redirects them to the login screen.
- Exit (X): Exits the application.
4. New Transfer Screen
- Users perform transfers by entering receiver and amount details.
  - Sender: Automatically filled in by the system.
  - Receiver: The receiver's account number is manually entered.
  - Amount: If the entered amount exceeds the available balance, a warning is displayed. If not, the transfer button completes the transfer. After the transfer, users can return to the Home Page using the back button, where the updated balance is displayed.
5. Transfer History
- Displays detailed information about all transfer transactions (sent/received) on the Home Page.
6. My Account Screen
- Displays the user’s personal information, including first name, last name, phone number, national ID, account number, password, and bank balance.
- All fields except the account number can be updated.
- Includes an option to delete the account. If the account is deleted, the user is redirected to the sign in screen.

Usage
- Run the application.
- Enter your sign in credentials on the sign in screen or create a new account if you don’t have one.
- Perform your desired operations from the Home Page.
- Sign out from your account or exit the application when finished.

Requirements
- .NET Framework 4.5 or later.
- SQL Server or a compatible database connection.

![1](https://github.com/user-attachments/assets/8112b911-7894-49a1-ac9e-bcb47dae2e8c)

![2](https://github.com/user-attachments/assets/c52cfeb8-9f28-40d4-ac8c-50207ac18697)

![3](https://github.com/user-attachments/assets/1efecd4e-8caf-4484-a7b5-41937cd2fcae)

![4](https://github.com/user-attachments/assets/709f8068-a044-4adf-9cc6-cfbe2514ba62)

![5](https://github.com/user-attachments/assets/b96291b2-0081-459d-9dbe-cc83c1a54a1c)

![6](https://github.com/user-attachments/assets/a2706ad4-8957-43a8-97ed-3a1608fbda06)

![7](https://github.com/user-attachments/assets/0b2ed383-38a2-40cc-8e02-5ba27c40fa5e)

![8](https://github.com/user-attachments/assets/1a5c3ac8-d817-4150-bbd0-5ce111534e14)

![9](https://github.com/user-attachments/assets/0418d8ce-ad83-43d1-84e8-b9b8acaeaedb)

![10](https://github.com/user-attachments/assets/d8da85f6-2dc6-4658-bd07-63a5384f3aa7)






