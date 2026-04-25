# Investment Portfolio API

A RESTful API built with C# (.NET) for managing an investment portfolio, including stock registration and trade operations (buy and sell).

This project was created to practice backend development and simulate a real-world portfolio system where users can track assets and execute trades.

---

## Tech Stack

* C# (.NET)
* ASP.NET Core Web API
* SQL Server
* Swagger (OpenAPI)

---

## Project Structure

/Controllers   API endpoints (Portfolio, Stocks, Trades)
/Models        Domain models
/Services      Business logic
/Data          Database context

---

## Getting Started

### Clone the repository

```bash
git clone https://github.com/your-username/Api-Compra-e-Venda.git
cd Api-Compra-e-Venda
```

---

### Configure the database

Update the connection string in:

appsettings.json

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=InvestmentDb;Trusted_Connection=True;"
  }
}
```

---

### Run the application

```bash
dotnet restore
dotnet run
```

API will be available at:

http://localhost:5000

Swagger UI:

http://localhost:5000/swagger

---

## API Endpoints

### Portfolio

GET /api/portfolio
Returns a summary of the current portfolio.

---

### Stocks

GET /api/stocks
POST /api/stocks
GET /api/stocks/{id}
PUT /api/stocks/{id}
DELETE /api/stocks/{id}

#### Example Request

```json
{
  "symbol": "AAPL",
  "companyName": "Apple Inc.",
  "price": 180.50,
  "marketCap": 2800000000000,
  "sector": "Technology"
}
```

#### Example Response

```json
{
  "id": 1,
  "symbol": "AAPL",
  "companyName": "Apple Inc.",
  "price": 180.50,
  "marketCap": 2800000000000,
  "sector": "Technology",
  "createdAt": "2026-04-24T21:59:05.960Z"
}
```

---

### Trades

POST /api/trades/buy
POST /api/trades/sell
GET /api/trades
GET /api/trades/{id}

#### Example Request (Buy)

```json
{
  "ticker": "AAPL",
  "quantity": 10,
  "pricePerUnit": 150
}
```

#### Example Response

```json
{
  "id": 1,
  "ticker": "AAPL",
  "quantity": 10,
  "pricePerUnit": 150,
  "total": 1500,
  "type": "BUY",
  "createdAt": "2026-04-24T22:10:00Z"
}
```

---

## Business Rules

* Buying a stock increases its quantity in the portfolio
* Selling a stock decreases its quantity
* A sell operation cannot exceed the available quantity
* All trades are stored for history tracking
* Portfolio data is calculated based on executed trades

### Average Price Calculation

averagePrice =
(currentQuantity * currentPrice + newQuantity * newPrice) / totalQuantity

---

## Author

Thiago Xavier
