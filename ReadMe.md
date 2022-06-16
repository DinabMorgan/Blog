﻿# Blog Platform
## Objective
- Students will employ good software design and testing principles in order to create a full-stack, server-side-rendered, web application.
- Students will build the front-end portion using HTML and CSS. (No frameworks, No JavaScript... at all)
- Students will build the back-end portion using ASP.Net Core, Entity Framework and a SQL database.

## The Scenario
We've been hired by NobodyCares Inc. to build a Proof of Concept (PoC) application for a company looking to make the next new hot blogging platform! This being a PoC app, we don't (yet) have to worry about all of the security and user management concerns that we would have in a fully functional application. All our client wants from us are the beginnings of the actual User eXperience (UX). Our client also wants an in depth and COMPLETE look at our applications User Interface (UI), so let's make it look good.

## The Starter Project
You have been given an ASP.Net Core Web Application starter project. It is your job to construct an MVC application that contains the appropriate Models, Views, and Controllers as outlined here. Additionally, you must set up a relational database as we've done in class. Testing files are provided, but tests are not written. 

## Post Model
We can't very well have a blog without some posts. Each Post instance should include:
- Title
- Body
- Author
- PublishDate (Look into the DateTime class for this)
- Category (Content should have only one)

Seed your database with at least 2-3 examples of Post for each Category.

## Category Model
Each Category should have:
- Name
- Posts (Each Category could have multiple Posts instances)

Seed your database with at least 3 example Categories.

## Controllers
We need to direct traffic efficiently. All of our entities should be managed by their own Controller. For example, all interaction with Content should be isolated to one Controller. You may have to ACCESS other entities in your Controllers. But the main entities that Controller is meant to direct should be well organized.

## Views
We need Views to display all of our Posts. But we should also be able to view our Post based on the other identifying components we have (Categories). We should have Index Views that display the collections of all entities as well as Details Views to display an individual instance of an entity. We should have navigation very clearly presented on all pages so that the user is able to navigate through our application.

Our users should be able to add new Posts to the Post Index page. Title, Body, and Author data will be entered into a text box by the user, but Category should be selected from a drop down list (which can be hard coded in your html view) and Publish Date should be automatically generated by the system.

Alternatively, you can allow users to add new Post from the Category Details page. Title, Body, and Author data will be entered into a text box by the user. You can use the CreateById action to capture the appropriate CategoryId, eliminating the need for a Category drop down list.

In addition, give users the ability to update or delete an existing Post instance.

Make sure all collections are organized with proper containing elements (i.e. ol or ul for list items).

## User Stories
These should be found on your project board but you can also include them here for a complete ReadMe file.

## Tips for Getting Started
- Prepare
- KEEP IT SIMPLE! Our applications aren't complicated until WE make them that way.
- KEEP IT SIMPLE! So important that it gets two rules.
- Make the branches you'll need for your project (main and dev to start).

## Plan of Action
- Implement MVC principles for our Post model
- Implement MVC principles for our Category model
- Add navigation properties to establish that one Category has many Contents.
- Add migrations and update database.
- Add seed data for Categories and Contents.
- Check your SQL database. Are your database, tables, and seed data there as expected?
- Create Index and Details views for both Category and Content. Display all necessary properties and include navigation links.
- Test that your views work in the browser as expected.
- Implement the Create, Update, and Delete views for Content.
- Add navigation links to the Create, Update, and Delete views.
- Add a style sheet and style all your views.

## Stretch Tasks
Stretch tasks should only be attempted after all requirements have been met.
- A landing (home) page that welcomes the user to our application.
- Add a Tags model with a many to many relationship to Blog Content.
- Allow users to create a new Tags from the Tags Index page, and/or new Categories from the Categories Index page.
- Add Authentication and integrate a login page, registration page, and profile page
- Hide navigation components based on the login
- Modify the home page to reflect all user posts while the Post and Category controllers should control a specific posts of the logged in user.

## Grading
Use Object Oriented Programming principles to your advantage by reducing repetition and keeping the details of your classes hidden and private from other classes.

Proper use of MVC to organize your code. Appropriate Controllers, actions, and Views give users the ability to Read, Add, Update, and Delete Blog Posts.

Incorporation of Code First database design using Entity Framework. Seed data has been added to the tables and migrations are named and used appropriately.
