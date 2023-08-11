# Stock-Management-System
<br>
<a href="https://drive.google.com/drive/folders/1Nlarrq8VJ3A7CEgrfUUUuuEOP_qygTxz?usp=share_link">Application running screen recorder</a>

<h2>Introduction</h2><br>
This is also a standalone application that we developed for wholesale stock management
business by using our Business Processes and ERP knowledge.
We chose a whole sale stock management business for our assignment. We gathered information 
about their current system as well as its shortcomings and areas that need further improvements.
 In the stock management business we have chosen, all the tasks are done manually, including 
managing products , customers, suppliers, category and orders. This manual process is time 
consuming and prone to errors, which can have negative impacts on the business. For example, If 
there is a errors in tracking stock levels, it can result in lost sales or overstocked inventory, By 
mistakes in customer or supplier data can cause delayed or incorrect orders.
To avoiding these drawbacks, we have developed a digital module wise stock management system 
using C#. It is automate and streamlines many of the processes involved in managing stock based 
business. Also our system includes features such as product stock management, categories 
management, supplier management, customer management and order management.
We develop this system using user friendly interfaces to make all these features easy. Also, as a 
additional feature, we have provided the ability to join others (like customers and suppliers) to this 
application via stock manager. Also the dashboard provided to the admin shows the information 
about the customers, suppliers as well as the orders and the stocks in list view , so the admin can get 
a proper understanding about the relevant sections.
By switching from the old manual system to our new digital stock management system, we are able 
to increase the efficiency of the business by avoiding the errors cause by the manual method. And 
the system provides real-time access to stock levels, customer data, supplier data, and order data, 
allowing for better decision- making.
In this report we covered the design and execution of our stock management system.as well as the 
development process overall.

<h2>Activities</h2>

<h3>Product stock management </h3>
<p>All the stock management is done through this activity. All the things like adding products to the 
stock, editing the product details, deleting the existing products are done through this. This stoke 
management activity takes the responsibility to prevent the stock from being overloaded and 
maintain a stock of the size that the customer have.
</p>

<h3>Category management</h3>
<p>All the category management related activities are done through this category management activity. 
Adding categories, deleting categories and editing categories can be identified as. A main 
functionalities of this category management activity. This is responsible for ensure products are 
properly categorized. Through this we can identify the most popular and most profitable category.</p>

<h3>Supplier management</h3>
<p></p>Adding new suppliers to the system, update supplier information, removing suppliers that are no 
longer needed are the main functionalities of this activity. This supplier management is responsible 
for tracking suppliers orders and payments. And we can also identify the suppliers that provide 
quality products at most competitive price.</p>

<h3>Customer management</h3>
<p></p>Through this activity we can add new customers to the system , updating customers information, and 
removing customers that are no longer active. This activity is responsible for ensuring that customer 
orders are processed quickly and accurately. And we can also get information about the most 
valuable customers.</p>

<h3>Order management</h3>
<p></p>Place new order, remove orders are the main functions of this activity. We can also get an idea about 
the most popular products through this order management activity.</P>

<h2>Use Case Diagram</h2>

![Screenshot 2023-08-12 005208](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/bec2d065-1f66-4058-aa01-80b079f5f068)

<h2>Objects</h2>
<h3>Products</h3>
This object means the physical items that are managed and tracked through this stock management 
system.
<h3>Categories</h3>
This object is used to classify the products based on their common characteristics. For example, it 
can be classified based on the type and brand. Through this, inventories are organized so that 
management and navigation can be done easily.
<h3>Suppliers</h3>
This represents the individuals or organizations that provide products to our business. Each of these 
suppliers has attributes such as name and contact information.
<h3>Customers</h3>
 This represents the individuals or organizations who purchase products from our business. Each of 
these customers have attributes such as names, contact information, billing and shipping address, 
and payment details.
<h3>Orders</h3>
This represents requests placed by customers to purchase products. The order object typically 
contains information such as customer details, product details, order status, and shipping 
information.
<h3>Payment</h3>
This is where all the financial transitions related records are kept. Here the amount and the date of 
the purchased products are also recorded. 

<h1>System interfaces</h1>
<h2>Loading Screen</h2>

![Screenshot 2023-05-05 211943](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/996ec9f8-3448-4f3d-8aab-166225b55966)

<h2>Sign in Screen</h2>
<p>Stock manager admin account. It’s username = “ admin” and Password = “adm”</p>
<br>

![Screenshot 2023-05-05 212252](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/351377a6-93db-49fa-a2e6-bf2507e88fca)


<h2>This application contains five modules such as follows</h2>

<h3>1. Stock</h3>

![Screenshot 2023-05-05 212343](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/7f3369b5-67fc-4ea6-86df-562d3decb8ba)
![Screenshot 2023-05-05 215523](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/0681d3a2-99f3-4ee6-89d7-e03ce764d769)

<h3>2. Customer</h3>

![Screenshot 2023-05-05 215600](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/814ada9b-6d95-40d6-9973-695387765171)
![Screenshot 2023-05-05 215638](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/ee89edd6-e6c0-4d72-85e6-dae32ada662e)

<h3>3. Supplier</h3>

![Screenshot 2023-05-05 215706](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/9f15ea06-6cf0-4137-9fe3-697f3640caca)
![Screenshot 2023-05-05 215732](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/2086c21e-77d6-4755-a79c-b0b9774a558d)

<h3>4. Category</h3>

![Screenshot 2023-05-05 215757](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/6c82ccbc-1acb-4068-855b-121f1876fed4)

<h3>5. Orders</h3>

![Screenshot 2023-05-05 215948](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/f26bd109-85de-4c0c-a225-0efb5cd9c21f)

<h1>Sample of the database</h1>

![image](https://github.com/2000kavinda/Stock-Management-System/assets/98000159/4d5596a0-0076-4217-858a-3270c9f854ef)

