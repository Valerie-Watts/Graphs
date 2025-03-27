# Proyecto: Implementación de Grafos en C#

## Descripción del Proyecto y Objetivos
Este proyecto implementa una estructura de datos para grafos en C#, permitiendo la creación, manipulación y búsqueda en grafos dirigidos y no dirigidos.

Los objetivos principales son:
- Representar grafos mediante listas de adyacencia.
- Permitir la adición y eliminación de vértices y arcos.
- Implementar algoritmos de búsqueda en anchura (BFS) y profundidad (DFS).
- Facilitar la visualización de la estructura del grafo mediante la impresión de su lista de adyacencia.

## Instrucciones de Instalación y Uso
1. Clonar el repositorio o descargar los archivos `Graph.cs` y `Program.cs`.
2. Abrir el proyecto en un entorno de desarrollo compatible con C# (como Visual Studio o VS Code con extensiones para .NET).
3. Compilar y ejecutar el programa.
4. Seguir las instrucciones en pantalla para interactuar con el grafo.

## Ejemplos de Entrada y Salida
### Creación de un grafo dirigido y agregado de vértices y arcos
**Entrada:**
```
Do you wish your graph be directed? (Y/N)
Y
1. Add vertix
Enter number: 5
1. Add vertix
Enter number: 3
2. Add an Arc
Enter origin: 5
Enter destination: 3
3. Show Adjacency list
```

**Salida:**
```
5 --> [ 3 ]
3 --> [ ]
```

### Ejemplo de BFS y DFS
**Entrada:**
```
6. BFS
Enter origin: 5
```
**Salida:**
```
5 3
```

## Explicación del Código y Estructura del Proyecto
- `Graph.cs`: Define la clase `Graph`, que maneja la estructura del grafo y las operaciones principales (agregar, eliminar vértices/arcos y realizar BFS/DFS).
- `Program.cs`: Contiene el `Main`, que presenta un menú de interacción para que el usuario manipule el grafo mediante la consola.

## Créditos y Referencias
Desarrollado por Valerie Watts.
Basado en conceptos de teoría de grafos y estructuras de datos en C#.

