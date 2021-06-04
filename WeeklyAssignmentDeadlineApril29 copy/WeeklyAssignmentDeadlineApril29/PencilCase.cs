using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAssignmentDeadlineApril29
{
    public class PencilCase
    {
        public int NumberOfZippers;
        public int NumberOfItemsInsideThePencilCase;
        public string Colour;
        public string BrandName;
        public bool ZipperOpen;

        public PencilCase(int NumberOfZippers, int NumberOfItemsInsideThePencilCase, string Colour, string BrandName)
        {
            this.NumberOfZippers = NumberOfZippers;
            this.NumberOfItemsInsideThePencilCase = NumberOfItemsInsideThePencilCase;
            this.Colour = Colour;
            this.BrandName = BrandName;
            ZipperOpen = false;

        }

        public void Open()
        {
            ZipperOpen = true;
        }
        public void Close()
        {
            ZipperOpen = false;
        }
        public string info()
        {
            return $"Pencil Case: Number Of Zippers: {NumberOfZippers}, Number Of Items: {NumberOfZippers}, Colour: {Colour}, Brand: {BrandName}, ZipperOpen: {ZipperOpen}";
        }
    }
}
