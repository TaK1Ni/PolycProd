using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApp1
{
    public static class AddInf
    {
        private static List<Policlinic> policlinics;
        private const string jsonFilePath = "policlinics.json";

        public static void AddDoctorInformation(string selectedPoliclinic, string doctorNameSpecialization, string doctorService, string doctorAvailableDay)
        {
            string json = File.ReadAllText(jsonFilePath);

            policlinics = JsonConvert.DeserializeObject<List<Policlinic>>(json);

            Policlinic existingPoliclinic = policlinics.Find(p => p.Name == selectedPoliclinic);
            if (existingPoliclinic != null)
            {
                Doctor existingDoctor = existingPoliclinic.Doctors.Find(d => d.NameSpecialization == doctorNameSpecialization);
                if (existingDoctor != null)
                {
                    if (!existingDoctor.Service.Contains(doctorService))
                    {
                        existingDoctor.Service.Add(doctorService);
                    }

                    if (!existingDoctor.AvailableDays.Contains(doctorAvailableDay))
                    {
                        existingDoctor.AvailableDays.Add(doctorAvailableDay);
                    }
                }
                else
                {
                    Doctor newDoctor = new Doctor   
                    {
                        NameSpecialization = doctorNameSpecialization,
                        Service = new List<string> { doctorService },
                        AvailableDays = new List<string> { doctorAvailableDay }
                    };

                    existingPoliclinic.Doctors.Add(newDoctor);
                }
            }
            else
            {
                Policlinic newPoliclinic = new Policlinic
                {
                    Name = selectedPoliclinic,
                    Doctors = new List<Doctor>()
                };

                Doctor newDoctor = new Doctor
                {
                    NameSpecialization = doctorNameSpecialization,
                    Service = new List<string> { doctorService },
                    AvailableDays = new List<string> { doctorAvailableDay }
                };

                newPoliclinic.Doctors.Add(newDoctor);

                policlinics.Add(newPoliclinic);
            }

            //Сериализуем список поликлиник обратно в JSON
            string updatedJson = JsonConvert.SerializeObject(policlinics, Formatting.Indented);

            //Записываем обновленный JSON файл
            File.WriteAllText(jsonFilePath, updatedJson);

            //Показываем сообщение об успешном добавлении информации
            MessageBox.Show("Информация успешно добавлена!");


        }
    }
}