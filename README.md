# Simulated Notification System

A C# console application that demonstrates **event-driven architecture** using the **Publish/Subscribe (Pub/Sub) pattern**. Built as a practical example of how real-world notification systems work in fintech and enterprise applications.

## Overview

This project simulates a notification system where a single event can trigger multiple independent notification channels simultaneously. When a notification is sent, subscribed handlers react automatically — without the publisher knowing or caring who is listening.

## Architecture

The system is built around four core concepts:

**Publisher** — `NotificationService` fires an event when `SendNotification()` is called. It has no knowledge of who is subscribed.

**Subscribers** — `EmailNotifier`, `SMSNotifier`, and `LogNotifier` each independently handle the event by printing a simulated notification to the console.

**Event** — `OnNotificationSent` is the broadcast channel. Subscribers register using `+=` and unregister using `-=`.

**Data Package** — `NotificationEventArgs` carries the recipient name, message, and timestamp to every subscriber when the event fires.

## Project Structure
