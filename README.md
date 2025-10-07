# CLDV6212 POE PART 2

ABC Retailers 
Project Overview
ABC Retailers is an all-encompassing e-commerce solution that leverages contemporary cloud architecture to provide a reliable and scalable environment for online retail. The project showcases an advanced implementation of Azure serverless computing patterns, where business logic is decoupled from the presentation layers using a microservices architecture designed with the utmost care. The system provides full administration of customers, products, orders, and file uploads while utilizing Azure's advanced storage and compute functionalities for high availability and performance.

Architecture & Technical Implementation
The application has a clean separation of concerns with two primary components: the user interface layer is produced from an ASP.NET Core MVC frontend application, while backend services are built on Azure Functions. The MVC application is fast and responsive paged applications for managing the retail operations, while Azure Functions will manage all the business logic and data persistency utilizing various Azure Storage services to achieve this. 

Key Features
Frontend MVC Application: Created using ASP.NET Core, the MVC application supplies a contemporary, responsive platform to manage the full scope of retail operations. It offers rich CRUD functionality for all customers, products, and orders, and other specialized features such as file uploads for payment proof and real-time searching across all major entities. The application leverages dependency injection to communicate with the backend Functions via a typed HTTP client, allowing overall clean separation and testability.

Azure Functions Backend: This backend is made up of several triggered Functions, organized by domain (Customers, Products, Orders, and Uploads), as well as queue triggered functions that provide asynchronous processing. Each group of functions process specific business operations while keeping data integrity and error handling in check. The Functions implement APIs that the MVC application consumes, creating a clear contract between the front- and back-end.

Management for Storage Integration
This solution uses several of Azure's cloud storage services as an integrated data persistence layer. Azure Table Storage serves as the primary data store of structured entities for customers, products, and orders. It provides fast and inexpensive storage for operational data. Blob Storage supports unstructured content (product images and proof of payment for purchase orders) in a secure and scalable file storage option with access security. Queue Storage enables asynchronous communication between components to support ordered notifications and improvements in stock levels. File Share Storage creates additional persistence for contract documents and traceability, meeting business requirements.

Key Elements & Business Logic
Order Processing Pipeline: The order system manages a more complicated business process where each order that is created coordinates many synchronous actions. With the placement of a new order, the order system checks the availability of each product, reserves the product, calculates pricing, and generates messages immediately to the queue for follow-up notifications and inventory control. This accommodates data confirmations to keep website or customer experience up-to-date, and continually informs the administrator of ongoing activity.

File Management System: The complete upload capability provides security for document management for proof of payment. The files uploaded are stored both as an easy access to Blob Storage, plus File Share for archival storage. This on-boarding of the payments where there is an audit trail, and documents support other compliance business requirements for document management.

Searching and Filtering: Improved searching functionality across customers and products gives administrators advanced retrieval and reporting capabilities. The searching capabilities are integrated with the Functions backend and operate quickly and accurately, while respecting overall application performance.

This e-commerce platform illustrates modern cloud-native development practices, while also maintaining a solid foundation for retail operation management. Fully documented features and architecture make the e-commerce platform scalable for small to medium sized retail businesses to successfully create or improve their online operations.
