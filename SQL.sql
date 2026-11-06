CREATE TABLE Categoria (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion VARCHAR(255) NOT NULL,
    PorcentajeDescuento DECIMAL(5, 2) NOT NULL 
);

CREATE TABLE Aplicacion (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(150) NOT NULL,
    Descripcion VARCHAR(MAX),
    Desarrolladora VARCHAR(100),
    Precio DECIMAL(10, 2) NOT NULL,
    IdCategoria INT NOT NULL,
    
    
    CONSTRAINT FK_Aplicacion_Categoria FOREIGN KEY (IdCategoria) 
        REFERENCES Categoria(ID)
);


INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Productividad y Negocios', 10.00);
INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Juegos y Entretenimiento', 15.50);
INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Educación y Cursos', 20.00);
INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Salud y Bienestar', 5.00);
INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Herramientas y Utilidades', 12.00);
INSERT INTO Categoria (Descripcion, PorcentajeDescuento) VALUES ('Finanzas Personales', 25.00);