﻿namespace CityInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        //using ICollection to avoid null reference issues
        public ICollection<PointOfInterestDto> PointsOfInterest { get; set;} 
            = new List<PointOfInterestDto>();
    }
}
