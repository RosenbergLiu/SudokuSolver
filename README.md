
# Sudoku Solver Console App

## Run locally
Open terminal in the project root folder (where `SudokuSolver.csproj` located) 
<br /><br />
Run following command to start (.NET 8.0 sdk is required)
```csharp
dotnet run
```
## Ready to use sudoku puzzles
0 represents an empty cell
```csharp
[[0,9,0,8,6,5,2,0,0],[0,0,5,0,1,2,0,6,8],[0,0,0,0,0,0,0,4,0],[0,0,0,0,0,8,0,5,6],[0,0,8,0,0,0,4,0,0],[4,5,0,9,0,0,0,0,0],[0,8,0,0,0,0,0,0,0],[2,4,0,1,7,0,5,0,0],[0,0,7,2,8,3,0,9,0]]
```
```csharp
[[0,9,0,8,6,5,2,0,0],[0,0,5,0,1,2,0,6,8],[0,0,0,0,0,0,0,4,0],[0,0,0,0,0,8,0,5,6],[0,0,8,0,0,0,4,0,0],[4,5,0,9,0,0,0,0,0],[0,8,0,0,0,0,0,0,0],[2,4,0,1,7,0,5,0,0],[0,0,7,2,8,3,0,9,0]]
```
```csharp
[[0,9,0,8,6,5,2,0,0],[0,0,5,0,1,2,0,6,8],[0,0,0,0,0,0,0,4,0],[0,0,0,0,0,8,0,5,6],[0,0,8,0,0,0,4,0,0],[4,5,0,9,0,0,0,0,0],[0,8,0,0,0,0,0,0,0],[2,4,0,1,7,0,5,0,0],[0,0,7,2,8,3,0,9,0]]
```
```csharp
[[0,0,0,0,0,4,6,7,8],[0,0,0,9,0,0,0,0,4],[0,0,7,0,0,6,1,9,0],[0,9,8,7,6,0,0,0,2],[0,0,0,0,0,0,0,0,0],[6,0,0,0,3,2,9,1,0],[0,8,2,6,0,0,7,0,0],[7,0,0,0,0,3,0,0,0],[9,5,6,4,0,0,0,0,0]]
```
```csharp
[[0,0,7,0,0,1,0,0,5],[0,0,5,4,0,0,3,7,1],[0,0,0,0,0,0,4,8,0],[0,0,0,7,9,0,8,0,2],[0,9,0,0,0,0,0,3,0],[2,0,3,0,8,5,0,0,0],[0,8,4,0,0,0,0,0,0],[7,5,2,0,0,4,6,0,0],[1,0,0,2,0,0,7,0,0]]
```
```csharp
[[0,9,5,0,0,0,0,0,0],[0,6,0,0,9,0,0,0,0],[1,8,0,7,2,3,5,0,0],[0,0,0,3,0,0,0,1,7],[0,1,3,0,0,0,8,4,0],[6,7,0,0,0,1,0,0,0],[0,0,6,9,5,8,0,7,1],[0,0,0,0,1,0,0,6,0],[0,0,0,0,0,0,9,5,0]]
```
```csharp
[[0,0,7,6,3,0,5,4,0],[0,0,0,0,2,1,8,0,9],[0,0,0,0,0,0,3,0,0],[0,2,5,0,0,4,6,0,7],[0,0,0,0,0,0,0,0,0],[8,0,4,5,0,0,9,1,0],[0,0,8,0,0,0,0,0,0],[1,0,3,7,4,0,0,0,0],[0,5,2,0,1,3,7,0,0]]
```
```csharp
[[0,0,3,0,9,0,0,0,0],[0,8,0,4,5,0,0,0,0],[9,6,0,1,0,0,0,4,8],[6,0,0,2,7,0,0,0,0],[8,2,0,0,4,0,0,3,6],[0,0,0,0,6,1,0,0,5],[7,9,0,0,0,4,0,1,2],[0,0,0,0,1,5,0,9,0],[0,0,0,0,2,0,8,0,0]]
```
```csharp
[[0,0,0,0,0,7,0,0,5],[0,0,0,0,0,1,7,0,0],[0,6,9,5,8,2,0,0,0],[0,0,3,7,0,6,0,5,0],[6,2,0,0,5,0,0,9,7],[0,5,0,1,0,9,8,0,0],[0,0,0,8,6,3,5,1,0],[0,0,2,9,0,0,0,0,0],[1,0,0,2,0,0,0,0,0]]
```
```csharp
[[0,0,0,0,5,0,6,0,9],[0,2,0,0,8,0,0,5,0],[0,0,6,7,0,0,0,0,0],[7,0,5,8,0,2,3,4,0],[0,0,2,0,0,0,9,0,0],[0,9,3,5,0,7,8,0,2],[0,0,0,0,0,8,1,0,0],[0,7,0,0,4,0,0,8,0],[3,0,8,0,7,0,0,0,0]]
```
```csharp
[[0,1,4,7,0,9,0,2,5],[0,0,0,0,0,0,4,0,0],[0,9,0,0,0,4,0,1,3],[0,0,5,0,4,0,0,7,0],[0,8,0,0,7,0,0,5,0],[0,4,0,0,5,0,9,0,0],[8,5,0,2,0,0,0,4,0],[0,0,1,0,0,0,0,0,0],[6,7,0,4,0,1,5,9,0]]
```
```csharp
[[7,0,8,0,0,5,6,0,3],[0,0,0,0,0,9,0,0,0],[6,0,1,7,4,0,0,0,8],[1,2,0,0,8,0,0,0,0],[0,0,6,0,0,0,8,0,0],[0,0,0,0,5,0,0,6,1],[3,0,0,0,9,8,1,0,4],[0,0,0,5,0,0,0,0,0],[9,0,7,3,0,0,5,0,2]]
```
```csharp
[[6,0,0,0,0,4,5,9,1],[5,0,0,1,6,0,0,7,0],[0,4,0,9,0,0,6,0,0],[0,0,0,5,0,0,8,0,0],[0,6,0,0,3,0,0,4,0],[0,0,5,0,0,2,0,0,0],[0,0,4,0,0,1,0,5,0],[0,1,0,0,9,5,0,0,3],[3,5,9,6,0,0,0,0,2]]
```
```csharp
[[5,8,0,0,3,7,0,0,1],[0,6,0,0,0,0,0,4,0],[0,9,4,0,0,0,8,5,0],[0,0,5,0,6,4,0,1,0],[0,0,0,0,0,0,0,0,0],[0,1,0,7,8,0,5,0,0],[0,4,6,0,0,0,2,8,0],[0,5,0,0,0,0,0,3,0],[8,0,0,5,4,0,0,9,6]]
```
```csharp
[[5,7,9,0,0,3,1,4,2],[0,0,0,0,0,2,8,0,0],[0,0,0,5,1,0,0,0,0],[0,9,5,0,0,0,0,0,3],[4,0,0,0,0,0,0,0,8],[8,0,0,0,0,0,4,9,0],[0,0,0,0,2,9,0,0,0],[0,0,8,3,0,0,0,0,0],[9,2,1,8,0,0,7,3,5]]
```
```csharp
[[5,0,0,9,0,0,0,6,2],[0,9,1,0,2,6,7,0,0],[0,0,0,1,0,0,0,0,0],[0,0,0,0,0,8,0,2,0],[1,0,6,2,0,4,9,0,7],[0,5,0,3,0,0,0,0,0],[0,0,0,0,0,2,0,0,0],[0,0,2,4,3,0,6,7,0],[4,6,0,0,0,9,0,0,8]]
```
