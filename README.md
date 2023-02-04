# SupportDashAI

>  CRM with AI features

> !!! IMPORTANT !!! the project is in development process, IT IS NOT READY YET 

![](https://github.com/tsziming/SupportDashAI/blob/master/docs/SupportDashAILogo.png?raw=true)

## Short Description.
SupportDash AI is an innovative platform designed to provide companies and enterprises with a robust customer service and communication solution. Thanks to its advanced API and sockets for adapters and communication as well as its Blazor-based UI, SupportDash AI provides a quality user-experience for both support employees and customers.

The platform offers a number of features, such as the ability to send and receive messages from various sources, provide brief descriptions of customers and categories of interest, and provide product history and notes.
For demonstration purposes, SupportDash AI also provides a web demo and Telegram app for customers to get started. 

The main objective of SupportDashAI is to form a personalized picture of customer interests based on their feedback and to generate, store and make recommendations to customer support (e.g., possible options to respond to a customer) by preparing information and analyzing customer requests using OpenAI's linguistic models. I believe that this approach not only stimulates lead generation but also supports old customers.

## Common Architecture

![](https://github.com/tsziming/SupportDashAI/blob/master/docs/ArchitectureDiagram.png?raw=true)

SupportDashAI has a microservice architecture and consists of some parts and layers:
1. Dashboard for customer support employees (backend and frontend). ASP.NET Core Blazor server.
The Dashboard is the most used part of the program, through which all interactions with the platform are performed by customer support employees (hereafter referred to as Agents). 
Blazor is Microsoft's latest UI framework which offers a "C# For Frontend" approach, it is a simple and reliable replacement for modern solutions such as Angular and React, though Blazor is more complex and requires a good understanding of C# and OOP to use.
Blazor offers two models, the first is WebAssembly (like Angular, a one-page application that communicates with the server via APIs) and the second is Blazor Server, it uses SignalR and server side rendering to communicate between frontend and client, this approach is particularly popular for commercial SaaS solutions with dashboard, because although it is more secure and faster, it consumes too many resources for B2C applications. 
2. API and SignalR.
Customers use messengers, emails, sms, web chats in our online stores to communicate with the support team, so we offer two possible types of communication for adapters* to collect messages and snippets of communication from these data sources: APIs and sockets (SignalR). 
3. Adapters
As we mentioned in the previous paragraph, in order to collect each event in our deshboard, we need it to have endpoints that must be "open" for communication. To connect these endpoints with information from the data sources, we use adapters. For the demonstration project, we will make two of them, web chat and telegram. 
4. DDD logic.
The most important part of the program. It contains the logic, built using the modern approach - Domain Driven Design. This part sends emails, interacts with OpenAI Api, performs operations with database and all other things that is implied as ***business logic***. See preview to get the idea:

![](https://github.com/tsziming/SupportDashAI/blob/master/docs/SolutionDemo.png?raw=true)

5. OpenAI
For the AI part of the logic, we use OpenAI as a platform to process, analyze, predict, generate recommendations, etc.. 
6. Database (SQL Server).
Since we use Entity Framework Core, we don't have to worry about the exact database choice, so the default option is Microsoft SQL Server.


## Features
1. APIs and Sockets for Adapters and Communication - This feature implies APIs and sockets (via SignalR) to allow adapters and various means of communication between the application and its users.
2. Dashboard UI on Blazor - This feature is a SPA UI on Blazor, a .NET web framework that provides an interactive user experience.
⦁ Login with two roles - administrator and agent - this feature provides a login page with two different roles for users, administrator and agent.
⦁ Settings (administrator only) - this function provides settings for the administrator user only.
- OpenAI Token - Here the admin user enters a token obtained on [OpenAI platform](https://www.openai.com).
- Context compression boolean - this setting controls whether .
- Custom SMTP (mail server) settings
3. Chats - this feature provides chat options for customer support agents.
⦁ Send and receive messages from different sources - this feature allows both users to send and receive messages from different sources.
⦁ Providing three possible answers as an answer using artificial intelligence depending on the context - this feature uses artificial intelligence to provide three possible answers as an answer depending on the context of the question.
⦁ Providing a brief description of the customer and the categories of interest - this feature allows the user to provide a brief description of the customer and the categories of interest.
⦁ Product History - this feature allows the user to view the history of their products.
⦁ Notes - this feature allows the user to store notes.
⦁ Products - this function allows the user to access the products.
⦁ Categories - this function allows the user to access the categories.
4. Adapters, namely web demo application, possible Telegram application - this function gives the user access to the web demo application as well as the possible Telegram application.

## Roadmap

- [x] Create Project Structure
- [ ] Create DDD UML Diagram
- [ ] Implement Dashboard Features with Mocked AI
- [ ] Add MudBlazor for Dashboard UI 
- [ ] Create API & SignalR Endpoints
- [ ] Create Telegram and Web Demo Adapters
- [ ] Implement AI Business Logic

## Credits

Made by [tsziming](https://github.com/tsziming/SupportDashAI), MIT License.
