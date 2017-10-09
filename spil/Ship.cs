using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{ 
public class Ship
{
       
public Ship()
{
List<Ship> lstShips = new List<Ship>();

Ship s = new Ship()
{
    Name = "Battleship",
    Orientation = ShipOrientation.Horizontal,
    ExtentUnits = 4,
    Position_Row = x - 1,
    Position_Col = y - 1
};
lstShips.Add(s);

s = new Ship()
{
    Name = "Battleship",
    Orientation = ShipOrientation.Vertical,
    ExtentUnits = 4,
    Position_Row = x - 1,
    Position_Col = y - 1
};
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Destroyer",
Orientation = ShipOrientation.Horizontal,
ExtentUnits = 3,
        Position_Row = x - 1,
        Position_Col = y - 1
    };
lstShips.Add(s);

s = new Ship()
{
    Name = "Destroyer",
    Orientation = ShipOrientation.Vertical,
    ExtentUnits = 3,
    Position_Row = x - 1,
    Position_Col = y - 1
};
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Submarine",
    Orientation = ShipOrientation.Vertical,
    ExtentUnits = 3,
        Position_Row = x - 1,
        Position_Col = y - 1
    };
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Submarine",
    Orientation = ShipOrientation.Horizontal,
    ExtentUnits = 3,
    Position_Row = x - 1,
    Position_Col = y - 1
    };
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Carrier",
    Orientation = ShipOrientation.Horizontal,
    ExtentUnits = 5,
    Position_Row = x - 1,
    Position_Col = y - 1
    };
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Carrier",
    Orientation = ShipOrientation.Vertical,
    ExtentUnits = 5,
    Position_Row = x - 1,
    Position_Col = y - 1
    };
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Patrol Ship",
    Orientation = ShipOrientation.Vertical,
    ExtentUnits = 2,
    Position_Row = x - 1,
    Position_Col = y - 1
    };
    lstShips.Add(s);

    s = new Ship()
    {
    Name = "Patrol Ship",
    Orientation = ShipOrientation.Horizontal,
    ExtentUnits = 2,
    Position_Row = x - 1,
    Position_Col = y - 1
    };
    lstShips.Add(s);
    }



        
public string Name { get; private set; }
public object Orientation { get; private set; }
public int ExtentUnits { get; private set; }
public int Position_Row { get; private set; }
public int Position_Col { get; private set; }
public object ShipOrientation { get; private set; }
public object Horizontal { get; set; VerticalContentAlignment; }
}
}
