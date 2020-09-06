# Fitness Pro

## Fitness Pro is a computer program for a fitness club, sports club, gym, school and dance studio.

The customer base allows you to **conduct a deeper analysis** of your market segment. You can find out about your *customers' personal preferences, evaluate their shopping cart, order frequency and seasonality.* Such analysis will allow you to **conduct market research** and **make predictions** about customers and the **development of your business** in general.

## **Theoretical review**

Within the **.NET** platform, several namespaces are defined that allow you to interact with relational databases. Together, these namespaces are known as **.ADO.NET**.
To work with sql tables, I chose **Visual Studio tables**. Three tables will be created in them. The *admin* table for administrators' logins and passwords, the *clients* table, which will store all customer data, and the *check* table, which will store all editions of payment receipts to customers.

## **Description of work**

When you start the application, we can see the authorization window.


![alt text](https://github.com/mariayurchenko/FitnessPro/blob/master/foto/authorization.png "Authorization")


In the table you can see the registered logins and passwords.


![alt text][admin]


After entering the correct password, we can see the database itself, which has a tab ***customers***, ***accounts*** and ***mailings***. The **"Customers"** section stores all customers of this fitness center. By clicking the button with the image *+client*, we can add a client.


![alt text](https://github.com/mariayurchenko/FitnessPro/blob/master/foto/clients.png "Clients")


To do this, we need to keep his name, date of visit, date of birth, his phone number or email, and if you wish, you can write a note (the name of the coach he is working with or the key number from his locker).


![alt text][newclient]


When we click on the client, we can see two additional buttons. *Delete* and *change* button.


![alt text][deleteandchange]


When changing the client, we have the opportunity to specify the subscription period and change other data. When adjusting, you need to click "Save", refresh the page and we can see the new data we have entered.


![alt text][change]


Go to the "Accounts" tab. Below we can see the same buttons, namely: search, update and add a new receipt. Red bills indicate non-payment, and green - on paid receipts.


![alt text][receipt]


Let's try to add a new receipt. When you enter an existing id, the name after that id will be displayed immediately on the "Name" line. The status "paid" and "not paid" indicates whether the client paid the receipt immediately or just took it. In general, receipts are issued separately from this appendix. This is where the information about the receipts is stored. The administrator line indicates which administrator issued this receipt. The login of the administrator who logged in to this application is automatically started there.


![alt text][addreceipt]


When you click on the receipt, we see two additional buttons: *delete* and *change*.


![alt text][changereceipt]


Go to the "Newsletter" tab. She is responsible for obtaining customer data. On the "Birthday" tab, you can get information about people who have a birthday today or on a selected date.


![alt text][birthday]


On the "Invitations" tab, we have the opportunity to select the period from a certain date and after pressing the button with a magnifying glass, we will find those customers who stopped visiting the fitness center on selected dates.


![alt text][invite]

___

The program consists of six forms, namely: "Main Menu", "Authorization Window", "Add Customer", "Adjust Customer", "Add Receipts" and "Adjust Receipt".
To sum up, we have ready-made software with a carefully designed database that has all the necessary properties. In general, the application can be used if you select other sql servers so that the database can be accessed from different computers.

[admin]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/admin.png "Table admin"
[addnewclient]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/addnewclient.png "Add new client"
[addreceipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/addreceipt.png "Addreceipt"
[birthday]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/birthday.png "Birthday table"
[change]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/change.png "Change client"
[changereceipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/changereceipt.png "Change and delete receipt"
[invite]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/invite.png "invite"
[newclient]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/newclient.png "new client"
[receipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/receipt.png "receipt"
[deleteandchange]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/deleteandchange.png "Delete and change"
