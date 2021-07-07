using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class GroundPackage
    {
        //Constant Variables
        public const int LOW_ZIP = 00000; //Lowest Zip code.
        public const int HIGH_ZIP = 99999; //Highest Zip code.
        public const int DEFAULT_ORIGIN = 40202; //Default for invalid  destination zip code.
        public const int DEFAULT_DEST = 90210; //Default fro invalid origin zip code.
        public const double DEFAULT_METRIC_VALUE = 1.0; //Default for invalid package metrics.

        //Backing fields.
        private int _originZip; //Package's origin zip code.
        private int _destinationZip; //Package's destination zip code.
        private double _length; //Package's length.
        private double _width; //Package's width.
        private double _height; //Package's height.
        private double _weight; //Package's weight.

        //Constructor.
        //Precondition: All packaging info is correctly inputed.
        //Postcondition: A package is constrructed with the specified properties.
        public GroundPackage(int origin, int dest, double length, double width,
            double height, double weight)
        {
            OriginZip = origin;
            DestinationZip = dest;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        //origin Zip Property.
        public int OriginZip
        {
            //Precondition:
            //Postcondition:
            get
            {
                return _originZip;
            }
            //Precondition:
            //Postcondition:
            set
            {
                if (value >= LOW_ZIP && value <= HIGH_ZIP)
                    _originZip = value;
                else
                    _originZip = DEFAULT_ORIGIN;
            }
        }

        //Destination Zip Property
        public int DestinationZip
        {
            //Precondition: None
            //Postcondition: Destination Zip has been returned.
            get
            {
                return _destinationZip;
            }
            //Precondition: Value >= 00000 and Value >= 99999.
            //Postcondition: Destination zip set to a specified value.
            set
            {
                if (value >= LOW_ZIP && value <= HIGH_ZIP)
                    _destinationZip = value;
                else
                    _destinationZip = DEFAULT_DEST;
            }
        }

        //Length Property
        public double Length
        {
            //Precondition: None.
            //Postcondition: Returns the length.
            get
            {
                return _length;
            }
            //Precondition: Value > 0.
            //Postcondition: Length is set to a specified value.
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = DEFAULT_METRIC_VALUE;
            }
        }

        //Width Property
        public double Width
        {
            //Precondition: None.
            //Postcondition: Width is returned.
            get
            {
                return _width;
            }
            //Precondition: Value > 0.
            //Postcondition: Width is set to a specified value.
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = DEFAULT_METRIC_VALUE;
            }
        }

        //Height Property
        public double Height
        {
            //Precondition: None.
            //Postcondition: height is returned.
            get
            {
                return _height;
            }
            //Precondition: Value > 0.
            //Postcondition: Height is set to specified value.
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = DEFAULT_METRIC_VALUE;
            }
        }

        //Weight Property
        public double Weight
        {
            //Precondition: None.
            //Postcondition: Weight is returned.
            get
            {
                return _weight;
            }
            //Precondition: Value > 0.
            //Postcondition: Weight is set to specified value.
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = DEFAULT_METRIC_VALUE;
            }
        }

        //Zone Distance Property (Read Only)
        public int ZoneDistance
        {
            //Precondition: Takes the first digit from both zipcodes and finds the difference.
            //Postcondition: Returns the zoneDistance.
            get
            {
                int zoneDistance;//Holds the zone distance between zip codes.
                
                int firstDigitOrigin; //Holds the first digit of origin zip code.
                int firstDigitDest; //Holds the first digit of destination zip code.
                int TEN_THOUSAND = 10000; //Holds 10000.

                firstDigitOrigin = _originZip / TEN_THOUSAND;
                firstDigitDest = _destinationZip / TEN_THOUSAND;

                zoneDistance = firstDigitOrigin - firstDigitDest;
                zoneDistance = Math.Abs(zoneDistance);

                return zoneDistance;
            }
        }

        //CalcCost Method.
        //Precondition: None.
        //Postcondition: Calculates the total shipping cost of the package.
        public double CalcCost()
        {
            double shippingCost;//Holds the total shipping cost of package.
            const double MULTIPLIER_ONE = 0.20;//Holds 0.20
            const double MULTIPLIER_TWO = 0.5;//Holds 0.5

            shippingCost = (MULTIPLIER_ONE * (Length + Width + Height)) +
                (MULTIPLIER_TWO * (ZoneDistance + 1) * Weight);

            return shippingCost;
        }

        //ToString Method.
        //Precondition: None.
        //Postcondition: String is returned that shows the information of 
        //               the package. With each detail starting on a new line.
        public override string ToString()
        {
            return "Origin Zip Code: " + OriginZip.ToString("d5") +
                System.Environment.NewLine + "Destination Zip Code: " +
                DestinationZip.ToString("d5") + System.Environment.NewLine + "Length: "
                + Length + " in." + System.Environment.NewLine + "Width: " + Width
                + " in." + System.Environment.NewLine + "Height: " + Height +
                " in." + System.Environment.NewLine + "Weight: " + Weight + " lbs.";
        }
    }
}
