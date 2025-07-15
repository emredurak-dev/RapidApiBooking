# RapidAPI Booking System

A modern hotel booking web application built with ASP.NET Core MVC that integrates with RapidAPI's Booking.com API to provide real-time hotel search, listing, and detailed view functionality.

## 🚀 Features

- **Hotel Search**: Search hotels by city name with customizable check-in/check-out dates and guest counts
- **Hotel Listings**: Display search results with high-quality images, ratings, and pricing
- **Hotel Details**: Comprehensive hotel detail pages with cover images, pricing, and location information
- **Responsive Design**: Modern, mobile-friendly UI using Bootstrap and custom CSS
- **Real-time Data**: Live hotel data from Booking.com via RapidAPI
- **Image Management**: Intelligent image loading with fallback system for better user experience

## 🛠️ Technologies Used

- **Backend**: ASP.NET Core 8.0 MVC
- **Frontend**: HTML5, CSS3, Bootstrap, JavaScript
- **API Integration**: RapidAPI (Booking.com API)
- **JSON Processing**: Newtonsoft.Json
- **Styling**: Custom CSS with modern design patterns
- **Templates**: Sogo Hotel and Deluxe Hotel templates integration

## 📁 Project Structure

```
RapidApiBooking/
├── Booking.WebApp/
│   ├── Controllers/
│   │   └── BookingController.cs          # Main controller handling hotel operations
│   ├── Models/
│   │   ├── HotelViewModel.cs             # Model for hotel listings
│   │   ├── HotelDetailViewModel.cs       # Model for hotel details
│   │   ├── PhotosByHotelViewModel.cs     # Model for hotel photos
│   │   └── ErrorViewModel.cs             # Error handling model
│   ├── Views/
│   │   ├── Booking/
│   │   │   ├── Index.cshtml              # Homepage with search form
│   │   │   ├── GetAllHotels.cshtml       # Hotel listing page
│   │   │   └── GetHotelDetail.cshtml     # Hotel detail page
│   │   └── Shared/
│   │       ├── _Layout.cshtml            # Main layout template
│   │       ├── _ValidationScriptsPartial.cshtml
│   │       └── Error.cshtml              # Error page
│   ├── wwwroot/
│   │   ├── css/                          # Custom stylesheets
│   │   ├── js/                           # Custom JavaScript files
│   │   ├── lib/                          # Third-party libraries
│   │   ├── sogo-master/                  # Sogo hotel template assets
│   │   └── deluxe-master/                # Deluxe hotel template assets
│   ├── Program.cs                        # Application entry point
│   ├── appsettings.json                  # Configuration settings
│   └── Booking.WebApp.csproj             # Project file
└── RapidApiBooking.sln                   # Solution file
```

## 🔧 Installation & Setup

### Prerequisites
- .NET 8.0 SDK
- Visual Studio 2022 or VS Code
- RapidAPI account with Booking.com API access

### Steps

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd RapidApiBooking
   ```

2. **Configure API Keys**
   - Open `Controllers/BookingController.cs`
   - Update the `APIKEY` and `APIHOST` constants with your RapidAPI credentials:
   ```csharp
   private const string APIKEY = "your-rapidapi-key";
   private const string APIHOST = "booking-com18.p.rapidapi.com";
   ```

3. **Restore packages**
   ```bash
   dotnet restore
   ```

4. **Build the project**
   ```bash
   dotnet build
   ```

5. **Run the application**
   ```bash
   dotnet run --project Booking.WebApp
   ```

6. **Access the application**
   - Open your browser and navigate to `https://localhost:7069` or `http://localhost:5069`

## 🎯 API Integration

The application integrates with three main RapidAPI endpoints:

### 1. Location Search
- **Endpoint**: `/stays/auto-complete`
- **Purpose**: Convert city names to location IDs
- **Usage**: Initial search functionality

### 2. Hotel Search
- **Endpoint**: `/stays/search`
- **Purpose**: Get list of hotels for a location
- **Parameters**: locationId, checkinDate, checkoutDate, adults, children
- **Features**: Returns hotel list with basic info and images

### 3. Hotel Details
- **Endpoint**: `/stays/detail`
- **Purpose**: Get detailed information about a specific hotel
- **Parameters**: hotelId, checkinDate, checkoutDate
- **Features**: Returns comprehensive hotel data including pricing and room photos

### 4. Hotel Photos
- **Endpoint**: `/stays/get-photos`
- **Purpose**: Get high-quality hotel images
- **Usage**: Fallback for better image quality

## 🎨 UI/UX Features

- **Modern Design**: Clean, professional interface with card-based layouts
- **Responsive Grid**: Bootstrap-powered responsive design
- **Image Optimization**: Smart image loading with multiple fallback options
- **Loading States**: Smooth transitions and loading indicators
- **Error Handling**: Graceful error handling with user-friendly messages
- **Navigation**: Intuitive breadcrumb navigation and back buttons

## 📱 Responsive Design

The application is fully responsive and works seamlessly across:
- Desktop computers (1200px+)
- Tablets (768px - 1199px)
- Mobile phones (320px - 767px)

## 🔒 Security Features

- HTTPS enforcement
- Input validation for dates and parameters
- Exception handling for API failures
- Secure API key management

## 🚦 Error Handling

- **API Failures**: Graceful handling of API timeouts and errors
- **Image Loading**: Fallback images when hotel images fail to load
- **Invalid Inputs**: Validation for date formats and required fields
- **Network Issues**: User-friendly error messages for connectivity problems

## 📊 Performance Optimizations

- **Async Operations**: All API calls are asynchronous
- **Image Optimization**: Multiple image size options (max300, original)
- **Efficient Loading**: Smart image loading strategies
- **Caching**: Browser caching for static assets

## 🙏 Acknowledgments

- RapidAPI for providing the Booking.com API
- Bootstrap team for the responsive framework
- Sogo and Deluxe template creators for the beautiful UI components
- ASP.NET Core team for the excellent web framework

---

**Built with ❤️ using ASP.NET Core and RapidAPI** 

## 📷 Screenshots

<details> <summary>🏠 <strong>Home Page (Booking Index)</strong></summary> <img src="https://github.com/user-attachments/assets/e2b7d28c-8e56-4df5-8ece-3f181c3a43c8" width="800" alt="Booking Index Screenshot" /> </details>
<details> <summary>🔎 <strong>Search Reservation Page</strong></summary> <img src="https://github.com/user-attachments/assets/5ae0a3cf-d8d0-4bb5-b3b0-9b8f096b3a6d" width="800" alt="Search Reservation Screenshot" /> </details>
<details> <summary>🏨 <strong>Hotel Detail Page</strong></summary> <img src="https://github.com/user-attachments/assets/817771ab-9b9f-4437-b1b4-65fcee1846a3" width="800" alt="Hotel Detail Screenshot" /> </details>
