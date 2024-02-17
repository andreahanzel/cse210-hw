/*
+----------------------------+
|           Video            |
+----------------------------+
| - title: string            |
| - author: string           |
| - length: TimeSpan         |
| - comments: List<Comment>  |
+----------------------------+
| + AddComment(Comment): void|
| + DisplayVideoDetails(): void |
+----------------------------+
                |
                |
                v
+----------------------------+
|          Comment           |
+----------------------------+
| - commenterName: string    |
| - message: string          |
+----------------------------+
| + DisplayComment(): void   |
+----------------------------+
*/
