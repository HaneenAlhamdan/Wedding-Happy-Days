# Wedding-Happy-Day

## Introduction
In this project, We simulated the back-end of a Wedding-Happy-Day system using ASP.Net Core. Our aim was to comply with SOLID coding principles while performing this simulation.

---

## Wireframe

![Wireframe](https://user-images.githubusercontent.com/98957434/182961909-e7a99210-5412-45c8-b57c-879e7b8823a0.jpg)

---

## User Stories

### As Admin 

* As an administrator, it shows him the details of the halls, and he can add, edit and modify it and see the details.
* As an administrator, he displays the details of flower shops and can be added, edited and modified and see the details.
* As an administrator, he displays the car rental details and can add, edit and modify it and see the details.
* As an administrator, it shows him the details of Beauty Center and he can add, edit and modify it and see the details.
* As an administrator, he displays the details of a food buffet and can be added, edited and modified and see the details.
* As an administrator, he displays the details of Design & Fashion, and he can add, edit and modify it and see the details.
* As an administrator, download and replace images.



### As a user

* As a user, you can see Halls, Flower shops, Car rental, Beauty Center, Food buffet, Design & Fashion, and view details.
* As a user, you can register for an account on the site.
* As a user, anything you want to get can be stored inside a cart.
* As a user, you can view what has been acquired inside the cart.

---

## Domain Modeling

![Modeling](https://user-images.githubusercontent.com/98957434/183136817-e10b95b4-434b-42ca-916f-71553d2495e4.jpg)

---


## Database Schema Diagram

![ERD](https://user-images.githubusercontent.com/98957434/183130318-7a89c86f-7ac3-47ca-a687-9898687dc62e.png)


- Wedding : is a class which holds the properties Groom'sName,Bride'sName,WeddingDate, Estimated amount of costs.
- Halls :Has Foreign KeyID , Name, Email,Phone,Price,Image,Description.
- Flower shops :Has Foreign KeyID ,Name, Email,Phone,Price,Image,Description.
- Car rental :Has Foreign KeyID ,Name, Email,Phone,Price,Image,Description.
- Beauty Center :Has Foreign KeyID ,Name, Email,Phone,Price,Image,Description.
- Food buffet :Has Foreign KeyID ,Name, Email,Phone,Price,Image,Description.
- Design & Fashion ::Has Foreign KeyID ,Name, Email,Phone,Price,Image,Description.
- Customer : The simple class have properties ID ,FirstName,LastName,Email,Password,confirmPassword.
- Order : Simple class has properties Id, OrdareDate.

---

