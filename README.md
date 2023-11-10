# Basketball Shoe Management System Usage Report

+ What is it ?

  A Management System Designed for Basketball Shoe Retailers

+ What can i do with it?

​	As a basketball shoe retailer, you can use this system to manage your store.

+ What functions does it have?

​	It can help you track the quantity of basketball merchandise, including incoming stock, outgoing stock, damaged items, and 	even provide overall trends within a week. It can also assist you in quickly locating specific basketball shoes in your 	  warehouse and checking their availability. In summary, it can help you maintain comprehensive records of all sales-related   information about basketball shoes

+ Why was this system developed?

  My younger cousin works as a basketball shoe reseller, and it's very tedious for him to  record information using Excel spreadsheets every time. Therefore, I hope to assist him using the knowledge I've acquired.

## 1. Accessing the Website

+ First, you will receive a compressed file

+ Second, unzip this file

+ Third, locate the file

![image-20231106124259989](Report.assets/image-20231106124259989.png)

+ Fourth, open and debug the file using your development environment to access the website.

## 2. Website Layout

In this section, we explore the layout and the main sections of the website. It helps users understand the structure of the site.

### 2.1 Header Section

The header of the system includes the website name "Sneaker Warehouse Management System." This is a fixed area located at the top of the page, typically used to display the website's title and identity.

Code：

```HTML
<div class="layui-layout layui-layout-admin">
    <div class="layui-header">
        <div class="layui-logo layui-hide-xs layui-bg-black">球鞋仓库管理系统</div>
        
</div>
```

Result：

![image-20231105143849126](Report.assets/image-20231105143849126.png)

### 2.2 Navigation Menu

The navigation menu is a vertical navigation area located on the left side, used to navigate to different sections of the system. This includes Warehouse Information, Shipment Warehouse Information, Damage Warehouse Information, and various application management functions.

Code：

```HTML
<div class="layui-side layui-bg-black">
    <div class="layui-side-scroll">
        <ul class="layui-nav layui-nav-tree" lay-filter="test">
            <li class="layui-nav-item"><a href="/Goos/GoodsPuls" id="click_a">Warehouse Information</a></li>
            <li class="layui-nav-item"><a href="/Goos/ChuGoodsPuls" id="click_b">Shipment Warehouse Information</a></li>
            <li class="layui-nav-item"><a href="/Goos/RuGoodsPuls" id="click_c">Damage Warehouse Information</a></li>
            <li class="layui-nav-item"><a href="/Goos/AdminIndex" id="click_d">Inventory Application Management</a></li>
            <li class="layui-nav-item"><a href="/Goos/ChuAdmin" id="click_e">Shipment Application Management</a></li>
            <li class="layui-nav-item"><a href="/Goos/DamageAdmins" id="click_f">Damage Application Management</a></li>
        </ul>
    </div>
</div>
```

Result：

![image-20231105144531247](Report.assets/image-20231105144531247.png)

### 2.3 Content Section

The content section is located to the right of the navigation menu and is used to display the main content of the system. This is the primary area where users interact with the system, including tables, forms, and other page elements.

Code：

```html
<div class="container body-content" style="margin: 60px 20px 0px 220px;">
    @RenderBody()
</div>

```

Result：

![image-20231105144711844](Report.assets/image-20231105144711844.png)

![image-20231105144730609](Report.assets/image-20231105144730609.png)

![image-20231105144748316](Report.assets/image-20231105144748316.png)

![image-20231105144814303](Report.assets/image-20231105144814303.png)

​                                   So on ...

### 2.4 Footer Section

The footer area displays the current time and provides additional information or links for the system. This typically includes copyright information, contact details, and more.

The system uses the Layui frontend framework to implement these layout sections, providing users with an intuitive interface to access various system functions.

Code：

```html
<div class="layui-footer">
    <!-- Fixed bottom area -->
    <div class="showTime">Current Time: November 1, 2023 &nbsp;&nbsp;&nbsp; 8:35:16 AM</div>
</div>

```

Result：

![image-20231105145440866](Report.assets/image-20231105145440866.png)

## 3. Utilizing Website Features

Here, we explain how to use various features of the website. This may include navigation, user interactions, or other functionalities.

### 3.1 Log in

+ How to log in？

  First, register an account and password.

  Click here to sign up for a new account.

  ![image-20231105151159646](Report.assets/image-20231105151159646.png)

  Fill in each information in turn

  ![image-20231105151538424](Report.assets/image-20231105151538424.png)

  All is ok，you can sign up ，Now！

  ![image-20231105151731726](Report.assets/image-20231105151731726.png)

  you will see this

  ![image-20231105151754640](Report.assets/image-20231105151754640.png)

  After click，you will see this page：

  ![image-20231105151916988](Report.assets/image-20231105151916988.png)

  You can see the total data, which includes the number of purchases, shipments, and losses, and even the overall trend over the course of a week.

  *Of course, all of this data is currently fabricated.*  

### 3.2 Warehouse Information

You can click here to get in Warehouse

![image-20231105212322680](Report.assets/image-20231105212322680.png)

and you can see detailed information for all products, including product name, product ID, product brand, product specifications, product type, product quantity, and product storage location.,for example:

![image-20231105212608078](Report.assets/image-20231105212608078.png)

### 3.3 Incoming Goods Registration

Click here to initiate the incoming goods registration process.

![image-20231105213030133](Report.assets/image-20231105213030133.png)

Next, you will see the following content：

![image-20231106104532438](Report.assets/image-20231106104532438.png)

After entering all the information, you can proceed to place it in your warehouse!

### 3.4 Incoming Inventory Record

Click here，

![image-20231106104920845](Report.assets/image-20231106104920845.png)

You will see the entry time, the storage warehouse, and other information about the product.

![image-20231106105024604](Report.assets/image-20231106105024604.png)

### 3.5  Outgoing Goods Registration

Click here

![image-20231106105235662](Report.assets/image-20231106105235662.png)

Next, enter the product's ID, quantity, and the outgoing warehouse, and you can successfully complete the shipment.

![image-20231106105329173](Report.assets/image-20231106105329173.png)

### 3.6 Outgoing Inventory Record

In here

![image-20231106105436296](Report.assets/image-20231106105436296.png)

You will see the product's outbound time, storage warehouse, and other information about the product.

![image-20231106105519927](Report.assets/image-20231106105519927.png)



### 3.7 Goods Damage Registration

Here, you can register information about damaged goods.

 	![image-20231106105657465](Report.assets/image-20231106105657465.png)

![image-20231106105810693](Report.assets/image-20231106105810693.png)



### 3.8 Goods Damage Report Form

Here, you can view all the information about damaged goods.

![image-20231106105914392](Report.assets/image-20231106105914392.png)

![image-20231106105951627](Report.assets/image-20231106105951627.png)



## 4. Technical Demonstrations

### 4.1 Models

Explanation of the models created for the website, detailing their purposes and usage.

![image-20231106111655773](Report.assets/image-20231106111655773.png)

1. `Admin_ID`: Represents the unique identifier for an admin, typically an integer (`int`).
2. `Admin_Uid`: Represents the username of an admin, typically a string.
3. `Admin_Pwd`: Represents the password of an admin, typically a string.
4. `Admin_Phone`: Represents the phone number of an admin, typically a string.



![image-20231106111735173](Report.assets/image-20231106111735173.png)

1. `Chu_ID`: Represents the unique identifier for a "Goods_Chu" item, typically an integer (`int`).
2. `Chu_Uid`: Represents a nullable integer field.
3. `Chu_Name`: Represents the name of the item, typically a string.
4. `Chu_Brand`: Represents the brand of the item, typically a string.
5. `Chu_Spec`: Represents the specifications of the item, typically a string.
6. `Chu_Type`: Represents the type of the item, typically a string.
7. `Chu_Number`: Represents the quantity or number of items, typically an integer (`int`).
8. `Chu_Time`: Represents a date and time associated with the item, of type `System.DateTime`.
9. `Chu_state`: Represents the state or status of the item, typically an integer (`int`).
10. `Chu_Place`: Represents a nullable integer field.



![image-20231106111924194](Report.assets/image-20231106111924194.png)

1. `Damage_ID`: Represents the unique identifier for a "Goods_Damage" item, typically an integer (`int`).
2. `Damage_Uid`: Represents a nullable integer field.
3. `Damage_Name`: Represents the name of the damaged item, typically a string.
4. `Damage_Brand`: Represents the brand of the damaged item, typically a string.
5. `Damage_Spec`: Represents the specifications of the damaged item, typically a string.
6. `Damage_Type`: Represents the type of the damaged item, typically a string.
7. `Damage_Number`: Represents the quantity or number of damaged items, typically an integer (`int`).
8. `Damage_Time`: Represents a date and time associated with the damage, of type `System.DateTime`.
9. `Damage_state`: Represents the state or status of the damaged item, typically an integer (`int`).
10. `Damage_Place`: Represents the place or location associated with the damage, typically a string.



![image-20231106112017691](Report.assets/image-20231106112017691.png)

1. `Ru_ID`: Represents the unique identifier for a "Goods_Ru" item, typically an integer (`int`).
2. `Ru_Uid`: Represents the user identifier associated with the item, typically a string.
3. `Ru_Name`: Represents the name of the item, typically a string.
4. `Ru_Brand`: Represents the brand of the item, typically a string.
5. `Ru_Spec`: Represents the specifications of the item, typically a string.
6. `Ru_Type`: Represents the type of the item, typically a string.
7. `Ru_Number`: Represents the quantity or number of items, typically an integer (`int`).
8. `Ru_Time`: Represents a date and time associated with the item, of type `System.DateTime`.
9. `Ru_state`: Represents the state or status of the item, typically an integer (`int`).
10. `Ru_Place`: Represents a nullable integer field.



![image-20231106112057142](Report.assets/image-20231106112057142.png)

1. `GoodsDBEntities1` is a DbContext class that is used to interact with the database. It derives from the DbContext class provided by Entity Framework.
2. The constructor of `GoodsDBEntities1` specifies the connection string that the context should use when connecting to the database. In this case, it uses a connection string named "GoodsDBEntities1."
3. The `OnModelCreating` method is overridden and contains a call to `throw new UnintentionalCodeFirstException()`. This is often generated by Entity Framework when using database-first or model-first approaches to indicate that this context is not used for code-first migrations.
4. The class includes virtual DbSet properties for various entity types, such as `Admin_Info`, `Goods`, `Goods_Chu`, `Goods_Damage`, `Goods_Ru`, and `Room`. These DbSet properties allow you to query and interact with the respective database tables.



![image-20231106112148206](Report.assets/image-20231106112148206.png)

1. `Room` is a partial class that represents a room entity. It contains properties and associations that define the structure and relationships of the room.
2. `Room_ID`: Represents the unique identifier for a room, typically an integer (`int`).
3. `Room_name`: Represents the name of the room, typically a string.
4. The class includes navigation properties (`Goods`, `Goods_Chu`, and `Goods_Ru`) that define the relationships between the `Room` entity and other related entities. These properties are collections of related entities, allowing you to access goods associated with this room.
5. The constructor for the `Room` class initializes the navigation properties with empty collections, ensuring that they are not null when used.



![image-20231106112216525](Report.assets/image-20231106112216525.png)

1. `Goods` is a partial class that represents a goods entity. It contains properties and associations that define the structure and relationships of the goods.
2. `Goods_ID`: Represents the unique identifier for a goods item, typically an integer (`int`).
3. `Ru_Uid`: Represents the user identifier associated with the goods item, typically a string.
4. `Goods_Name`: Represents the name of the goods, typically a string.
5. `Goods_Brand`: Represents the brand of the goods, typically a string.
6. `Goods_Spec`: Represents the specifications of the goods, typically a string.
7. `Goods_Type`: Represents the type of the goods, typically a string.
8. `Goods_Number`: Represents the quantity or number of goods, typically an integer (`int`).
9. `Goods_Place`: Represents a nullable integer field.
10. The class includes navigation properties (`Room`, `Goods_Chu`, and `Goods_Damage`) that define the relationships between the `Goods` entity and other related entities. These properties are collections of related entities, allowing you to access rooms and associated data for the goods.
11. The constructor for the `Goods` class initializes the navigation properties with empty collections, ensuring that they are not null when used.

### 4.2 CSS

+ Style Initialization

​	![image-20231106113003479](Report.assets/image-20231106113003479.png)

+ Body Styles

  ![image-20231106113017131](Report.assets/image-20231106113017131.png)

+ Main Container Styles

  ![image-20231106113043147](Report.assets/image-20231106113043147.png)

+ Panel Switching Styles

  ![image-20231106113112911](Report.assets/image-20231106113112911.png)

+ Panel Content Styles

  ![image-20231106113148444](Report.assets/image-20231106113148444.png)

+ Button Styles

  ![image-20231106113233467](Report.assets/image-20231106113233467.png)

+ Hidden Element Styles

​	![image-20231106113252697](Report.assets/image-20231106113252697.png)

### 4.3 JavaScript

![image-20231106122454568](Report.assets/image-20231106122454568.png)

1. It starts by using `document.querySelector` to select various HTML elements that need to be manipulated, such as `.switch-panel`, `.register-login-panel`, `#login`, `#register`, `.register`, and `.login`.
2. Event listeners are added to two buttons, `#switch1` and `#switch2`, using `addEventListener`. When these buttons are clicked, the `switchStyle` function is executed.
3. The `switchStyle` function is responsible for the actual switching logic. It uses `classList.toggle` to toggle CSS class names, which in turn changes the styles of elements. The following toggles are mainly performed:
   - Toggling the styles of `switchPanel` and `register_login_Panel` to achieve a sliding effect for the panels.
   - Toggling the styles of `switchPanel_login` and `switchPanel_register` to control the visibility of buttons.
   - Toggling the styles of `loginPanel` and `registerPanel` for button visibility as well.

### 4.4 Feature Implementation

1. **Create Entity Models**:
   - Create data entity models using Entity Framework or other ORM tools that represent data objects in your application.
   - Define properties for the entity models, such as name, description, price, etc.
   - Set up relationships between entities, such as one-to-many, many-to-many, etc.
2. **Create Controllers**:
   - Create a new MVC controller, naming and locating it based on the name of your entity and business logic.
   - In the controller, create methods to perform CRUD operations, such as `Create`, `Read`, `Update`, and `Delete`.
3. **Create Views**:
   - Create views for each CRUD operation, typically naming them based on the corresponding action, such as `Create.cshtml`, `Read.cshtml`, `Update.cshtml`, and `Delete.cshtml`.
   - Use HTML form elements in the views to render the user interface for input and data viewing.
   - Utilize a view template engine like Razor to render the views and pass model data to the views for display and processing.
4. **Implement CRUD Methods**:
   - Write create, read, update, and delete methods in the controller.
   - In the create method, receive user input, validate the data, and save it to the database.
   - In the read method, retrieve data from the database and pass it to the view.
   - In the update method, receive user input and save it to the database to update records.
   - In the delete method, receive the identifier for the record to be deleted and remove it from the database.
5. **Set Up Routing**:
   - In the application's routing configuration, ensure there are appropriate routing rules to map HTTP requests to CRUD operation methods.
   - Typically, routing rules will include the controller, action, and optional parameters to determine which action is to be executed.
6. **Test and Validate**:
   - Conduct thorough testing to ensure that CRUD operations work as expected.
   - Verify the creation, reading, updating, and deletion of data to ensure that records in the database accurately reflect the actions.
   - Ensure that form validation and validation of user input data are effective in preventing potential security issues.



