// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace DataImport.EdFi.ModelsV25.EnrollmentComposite
{
    public class School
    {
        public string Id { get; set; }

        public string NameOfInstitution { get; set; }

        public string ShortNameOfInstitution { get; set; }

        public SchoolLocalEducationAgency LocalEducationAgencyReference { get; set; }
    }

    public class SchoolLocalEducationAgency
    {
        public string Id { get; set; }
    }
}
