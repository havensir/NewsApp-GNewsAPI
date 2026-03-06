# NewsApp (.NET MAUI)

## Overview
NewsApp is a mobile application built using **.NET MAUI** that allows users to browse and read news articles by category. The app retrieves live news data from the **GNews API** and displays it in a simple and user-friendly interface.

Users can select a news category, view a list of articles, and open an article to see more details.

---

## Features
- Browse news by category (Technology, Sports, Business, Health, etc.)
- View a list of news articles with images and titles
- Open a detailed page for each article
- Navigate between pages using stack-based navigation
- Data loaded dynamically from the GNews API

---

## Pages

### NewsHomePage
Displays available news categories and a list of trending articles.

### NewsListPage
Shows articles related to the selected category.

### NewsDetailPage
Displays detailed information about the selected article including image, title, and description.

---

## Navigation Flow

NewsHomePage  
↓  
NewsListPage (selected category)  
↓  
NewsDetailPage (selected article)

---

## Technologies Used
- .NET MAUI
- C#
- XAML
- GNews API

---

## API
This project uses the **GNews API** to retrieve news articles.

https://gnews.io
