# SignalR Chat Client (Windows Forms)

This Windows Forms application serves as a client for the SignalR chat service. It allows users to connect to the chat server, send and receive messages, and participate in group conversations. The application utilizes C# for logic implementation, Entity Framework for data management, and delegates for inter-thread communication due to the single-threaded nature of Windows Forms applications.

## Features

- **Real-time Chatting**: Connect to the SignalR chat service to exchange messages in real-time.
- **Individual and Group Chat**: Engage in one-on-one conversations or join group chats.
- **Message Handling with Delegates**: Utilizes delegates for communication between different threads, ensuring smooth operation within the Windows Forms environment.
- **Data Persistence with Entity Framework**: Stores and retrieves chat history using Entity Framework, allowing seamless access to previous conversations.

## Technologies Used

- **C#**: Programming language used for the application logic and event handling.
- **Windows Forms**: Framework for building desktop applications with a graphical user interface (GUI).
- **SignalR Client**: Client library for connecting to and interacting with SignalR services.
- **Entity Framework (EF)**: Object-relational mapping (ORM) framework for .NET, used for database access and persistence.
- **Delegates**: C# feature used for defining and invoking callback methods, facilitating inter-thread communication.


