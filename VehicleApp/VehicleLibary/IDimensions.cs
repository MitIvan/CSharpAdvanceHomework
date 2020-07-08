using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibary
{
    interface IDimensions
    {
      
            int Mass { get; set; }

            int Height { get; set; }

            int Length { get; set; }

            void PrintDimensions();
        
    }
}
