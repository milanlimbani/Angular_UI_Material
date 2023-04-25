using AutoMapper;
using StudentAdminProtal.api.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data = StudentAdminProtal.api.DataModels;


namespace StudentAdminProtal.api.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, Data.Student>
    {
        public void Process(UpdateStudentRequest source, Data.Student destination, ResolutionContext context)
        {
            destination.Address = new Data.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}

