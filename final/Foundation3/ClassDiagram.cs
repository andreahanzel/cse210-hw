/*
+-------------------------+
|          Event          |
+-------------------------+
| - eventName: string (protected) |
| - eventDate: DateTime (protected)|
| - location: string (protected)  |
+-------------------------+
| + DisplayEvent(): void  |
| + GenerateMarketingMessage(): string |
+-------------------------+
            ^
            |
+-----------+-----------+
|                       |
v                       v
+------------------+   +------------------+
|      Lecture     |   |     Reception    |
+------------------+   +------------------+
|                  |   | - rsvpEmail: string |
+------------------+   +------------------+
| + GenerateMarketingMessage(): string |   | + GenerateMarketingMessage(): string |
+------------------+   +------------------+
            ^
            |
            |
            v
       +------------------+
       | OutdoorGathering |
       +------------------+
       | - weatherForecast: string |
       +------------------+
       | + GenerateMarketingMessage(): string |
       +------------------+
*/
