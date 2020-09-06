# Fitness Pro

## Fitness Pro is a computer program for a fitness club, sports club, gym, school and dance studio.

The customer base allows you to **conduct a deeper analysis** of your market segment. You can find out about your *customers' personal preferences, evaluate their shopping cart, order frequency and seasonality.* Such analysis will allow you to **conduct market research** and **make predictions** about customers and the **development of your business** in general.

## **Theoretical review**

Within the .NET platform, several namespaces are defined that allow you to interact with relational databases. Together, these namespaces are known as .ADO.NET.
To work with sql tables, I chose Visual Studio tables. Three tables will be created in them. The *admin* table for administrators' logins and passwords, the *clients* table, which will store all customer data, and the *check* table, which will store all editions of payment receipts to customers.

## **Description of work**

When you start the application, we can see the authorization window.

![alt text](https://github.com/mariayurchenko/FitnessPro/blob/master/foto/authorization.png "Authorization")

In the table you can see the registered logins and passwords.


![alt text]([https://github.com/mariayurchenko/FitnessPro/blob/master/foto/admin.png] "Table admin")


After entering the correct password, we can see the database itself, which has a tab for customers, accounts and mailings. The "Customers" section stores all customers of this fitness center. By clicking the button with the image + client, we can add a client.

![alt text]([https://github.com/mariayurchenko/FitnessPro/blob/master/foto/clients.png] "Clients")

To do this, we need to keep his name, date of visit, date of birth, his phone number or email, and if you wish, you can write a note (the name of the coach he is working with or the key number from his locker).

![alt text][newclient]

When we click on the client, we can see two additional buttons. Delete and change button. When changing the client, we have the opportunity to specify the subscription period and change other data. When adjusting, you need to click "Save", refresh the page and we can see the new data we have entered.

![alt text][change]

Go to the "Accounts" tab. Below we can see the same buttons, namely: search, update and add a new receipt. When you click on the receipt, we see two additional buttons: delete and adjust.

![alt text][receipt]

Let's try it out with a new receipt. When you enter an id on a row of "PIB", it will immediately appear as an id. The status "paid" and "not paid" are ordered for those who, having paid for the client, took a receipt for the first time. The receipt of the receipt is seen okremo from the dodutku. Here you can also get information about receipts. The row of the administrator will be ordered by the administrator of the ticket. There, the administrator's login is automatically launched, which is a zaishov on a dodatok. Red bills indicate non-payment, and green - on paid receipts.

![alt text][addreceipt]

We can also delete or change the receipt.

![alt text][changereceipt]

Go to the "Newsletter" tab. She is responsible for obtaining customer data. On the "Birthday" tab, you can get information about people who have a birthday today or on a selected date.

![alt text][birthday]

On the "Invitations" tab, we have the opportunity to select the period from a certain date and after pressing the button with a magnifying glass, we will find those customers who stopped visiting the fitness center on selected dates.

![alt text][invite]


[addnewclient]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/addnewclient.png "Add new client"
[addreceipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/addreceipt.png "Addreceipt"
[birthday]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/birthday.png "Birthday table"
[change]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/change.png "Change client"
[changereceipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/changereceipt.png "Change receipt"
[deleteandchange]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/deleteandchange.png "deleteandchange"
[invite]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/invite.png "invite"
[newclient]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/newclient "new client"
[receipt]: https://github.com/mariayurchenko/FitnessPro/blob/master/foto/receipt.png "receipt"

