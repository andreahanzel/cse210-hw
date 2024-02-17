/*
+-------------------------+
|       FitnessClass      |
+-------------------------+
| - className: string (protected) |
| - classTime: TimeSpan (protected) |
| - instructor: string (protected)|
+-------------------------+
| + DisplayClassDetails(): virtual void |
| + ListRequirements(): virtual void |
+-------------------------+
            ^
            |
+-----------+-----------+-----------+
|                       |                       |
v                       v                       v
+------------------+   +------------------+   +------------------+
|       Yoga       |   |      Pilates     |   |  StrengthTraining |
+------------------+   +------------------+   +------------------+
|                  |   |                  |   |                  |
+------------------+   +------------------+   +------------------+
| + DisplayClassDetails(): override void |   | + DisplayClassDetails(): override void |   | + DisplayClassDetails(): override void |
| + ListRequirements(): override void |   | + ListRequirements(): override void |   | + ListRequirements(): override void |
+------------------+   +------------------+   +------------------+
*/
