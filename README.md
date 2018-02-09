# __AddressBook : Addressing your Addressing needs__
### Helping you keep track of all your friends' contact information.
#### by Jasun Feddema

### __Description__
* This is an app that allows the user to create multiple Contacts. 
* Each contact is made up of a Name, a Phone Number, and an Address.  
* The user will be able to see all their contacts on the app's home page; and upon clicking the contact's name, see all the contact's details.
* If the user desires to cut ties with all the contacts in their life, they may delete all contacts with a very conspicuous button at the bottom of the home page.

### __Setup and Installation Requirements__
* __Install the .Net Framework:__
    * [.Net Core 1.1 SDK (Software Development Kit)](https://download.microsoft.com/download/F/4/F/F4FCB6EC-5F05-4DF8-822C-FF013DF1B17F/dotnet-dev-osx-x64.1.1.4.pkg)
    * [.Net runtime](https://download.microsoft.com/download/6/F/B/6FB4F9D2-699B-4A40-A674-B7FF41E0E4D2/dotnet-osx-x64.1.1.4.pkg)
    * See [Installing C#](https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c) for more specific instructions.
* __Clone or Download this Repository:__
    * [AddressBook-Epicodus](https://github.com/jaybojaybojaybo/AddressBook-Epicodus.git)
    * I would recommend cloning or saving it to your desktop for ease in navigation.
* __Setup the Program__
    * Use command line to navigate into the project folder ex: "../AddressBook-Epicodus"
    * While still in command line, run the following commands:
      1. dotnet restore
      2. dotnet build
      3. dotnet run
* __Run the Program__
    * Open a browser and navigate to "localhost:5000"
    * Click the link to "Add a new Contact"
    * Enter a "Name", a "Phone Number", and an "Address"
    * Hit the "Add New Contact" button or press Enter on your keyboard
    * If you want to see the contact's details, click on their name
    * If you want to add more contacts, click the "Add a new Contact" link
    * If you want to delete all the contacts, hit the "Clear All Contacts" button.
    
### __Support and contact details__

_To suggest changes, submit a pull request in the GitHub repository._

### __Technologies Used__

* HTML
* C#
* .Net
* Bootstrap
* CSS

### __Specifications__

#### When the user navigates to the "Add a Contact" page, the user can create a new contact with the fields provided and will be redirected to a directory of all contacts on the homepage.

__Example Input:__ 
  
  Name: "Jasun"   
  Phone Number: "(123)456-7890"    
  Address: "5555 Main St. Portland, OR 97204"    
  
__Example Output on the Homepage:__ 

  Jasun (a link that, once clicked, will bring the user to the contact's "Details" page)

#### When the user clicks on the individual Contact's link, the user can view each contact's details.

__Example Input:__     

clicking on the link "Jasun"    

__Example Output on the Details page:__     
    "Jasun's Details"    
    "Phone number: (123)456-7890"    
    "Address: 5555 Main St. Portland, OR 97204"    
    
#### When the user wants to delete all the contacts they have ever made with the app, the user can hit the "Clear All Contacts" button.

__Example Input:__     

clicking on the "Clear All Contacts" button.    

__Example Output:__     

redirect to fresh Homepage inviting the user to create new contacts.    

### __License__

*MIT License*

Copyright (c) 2018 **_Jasun Feddema_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
    

    
   
