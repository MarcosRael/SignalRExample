# SignalR Example with .NET 8

This is a basic example of using **SignalR** in a **.NET 8** application to implement real-time communication, such as a chat system. The project demonstrates how to set up a SignalR hub on the server and communicate with a simple HTML frontend using SignalR JavaScript client.

## Features

- Real-time communication between multiple clients.
- SignalR Hub configured on the server.
- Simple chat interface where users can send and receive messages.

## Prerequisites

Make sure you have the following installed on your machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Any modern web browser (e.g., Chrome, Firefox, Edge).

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/signalr-example.git
cd signalr-example
```

### 2. Install Dependencies

Before running the project, ensure that all required packages are installed:

```bash
dotnet restore
```

### 3. Run the Application

To run the application, use the following command:

```bash
dotnet run
```
The server will start, and you'll be able to access the application by opening a browser and navigating to:

```bash
http://localhost:5000
```
### 4. Test the Chat Application

1. Open multiple tabs or browser windows with the same URL.
2. Enter a username and message in each window.
3. Send a message, and it will appear in all windows in real time.










