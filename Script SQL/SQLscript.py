import sqlite3


# tabla = input().lower()


# cursor.execute('create table tablets (Brand varchar(15), Model varchar(15), Price integer, Description text, Shop varchar(22)')


def f_cellphones():
    while True:
        connection = sqlite3.connect('cbot.db')
        cursor = connection.cursor()

        brand = input('Inserte la marca:    ')

        model = input('Inserte el modelo:    ')

        price = float(input('Inserte el precio:    '))

        description = input('Inserte la descripcion:    ')

        shop = int(input('''
1- Palacio de Hierro    4- Amazon           7- Telcel
2- Sears                5- Mercado Libre    8- Movistar
3- Liverpool            6- Linio            9- AT&T
Inserte el numero correspondiente:    '''))

        match shop:
            case 1:
                shop = 'Palacio de Hierro'
            case 2:
                shop = 'Sears'
            case 3:
                shop = 'Liverpool'
            case 4:
                shop = 'Amazon'
            case 5:
                shop = 'Mercado Libre'
            case 6:
                shop = 'Linio'
            case 7:
                shop = 'Telcel'
            case 8:
                shop = 'Movistar'
            case 9:
                shop = 'AT&T'
        data = brand, model, price, description, shop
        cursor.executemany("INSERT INTO cellphones VALUES (?, ?, ?, ?, ?)", [data])

        connection.commit()
        connection.close()
        print('****************' * 2)


def f_smartwatches():
    while True:
        connection = sqlite3.connect('cbot.db')
        cursor = connection.cursor()

        brand = input('Inserte la marca:    ')

        model = input('Inserte el modelo:    ')

        price = float(input('Inserte el precio:    '))

        description = input('Inserte la descripcion:    ')

        shop = int(input('''
1- Palacio de Hierro    4- Amazon           7- Telcel
2- Sears                5- Mercado Libre    8- Movistar
3- Liverpool            6- Linio            9- AT&T
Inserte el numero correspondiente:    '''))

        match shop:
            case 1:
                shop = 'Palacio de Hierro'
            case 2:
                shop = 'Sears'
            case 3:
                shop = 'Liverpool'
            case 4:
                shop = 'Amazon'
            case 5:
                shop = 'Mercado Libre'
            case 6:
                shop = 'Linio'
            case 7:
                shop = 'Telcel'
            case 8:
                shop = 'Movistar'
            case 9:
                shop = 'AT&T'
        data = brand, model, price, description, shop

        data = brand, model, price, description, shop
        cursor.executemany("INSERT INTO smartwatches VALUES (?, ?, ?,?,?)", [data])

        connection.commit()
        connection.close()
        print('****************' * 2)


def f_tablets():
    while True:
        connection = sqlite3.connect('cbot.db')
        cursor = connection.cursor()

        brand = input('Inserte la marca:    ')

        model = input('Inserte el modelo:    ')

        price = float(input('Inserte el precio:    '))

        description = input('Inserte la descripcion:    ')

        shop = int(input('''
1- Palacio de Hierro    4- Amazon           7- Telcel
2- Sears                5- Mercado Libre    8- Movistar
3- Liverpool            6- Linio            9- AT&T
Inserte el numero correspondiente:    '''))

        match shop:
            case 1:
                shop = 'Palacio de Hierro'
            case 2:
                shop = 'Sears'
            case 3:
                shop = 'Liverpool'
            case 4:
                shop = 'Amazon'
            case 5:
                shop = 'Mercado Libre'
            case 6:
                shop = 'Linio'
            case 7:
                shop = 'Telcel'
            case 8:
                shop = 'Movistar'
            case 9:
                shop = 'AT&T'
        data = brand, model, price, description, shop

        data = brand, model, price, description, shop
        cursor.executemany("INSERT INTO tablets VALUES (?, ?, ?,?,?)", [data])

        connection.commit()
        connection.close()
        print('****************'*2)


print('Una vez registrados presione Ctrl + z o Ctrl + c')
tabla = int(input('''
Inserte 1 para celulares
        2 para smartwatch
        3 para tablets
'''))

match tabla:
    case 1:
        f_cellphones()
    case 2:
        f_smartwatches()
    case 3:
        f_tablets()
