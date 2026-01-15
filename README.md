# KmMeterFormatter

Lightweight .NET utility library to format kilometer and meter values into a standardized string representation.

---

## 🇧🇷 KmMeterFormatter

Biblioteca .NET para formatação padronizada de valores de quilômetro e metro, garantindo sempre três dígitos em cada campo.

---

## What it does

Formats kilometer and meter values into a fixed-width string using a custom separator.

Example:

```csharp
string result = KmMeterFormatter.ConcatKmMeter("23", "601", "+");
// result = "023+601"
```

---

## Installation

Install via NuGet:

```bash
dotnet add package KmMeterFormatter
```

---

## Usage

```csharp
using KmMeterFormatter;

string km = "5";
string meter = "32";
string separator = "-";

string formatted = KmMeterFormatter.ConcatKmMeter(km, meter, separator);
// Output: 005-032
```

---

## Behavior

- Pads `km` and `meter` with leading zeros to always have 3 digits.
- Concatenates values using a custom separator.
- Useful for road engineering, georeferencing systems and data normalization.

---

## Tests

Run unit tests with:

```bash
dotnet test
```
