using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace te1
{
    public static class JsonStorage
    {
        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true
        };

        public static void ExportToJson(string filePath)
        {
            var data = new AppData
            {
                Students = DataStore.Students.ToList(),
                Teachers = DataStore.Teachers.ToList(),
                Classes = DataStore.Classes.ToList(),
                NextStudentId = DataStore.NextStudentId,
                NextTeacherId = DataStore.NextTeacherId,
                NextClassId = DataStore.NextClassId
            };

            var json = JsonSerializer.Serialize(data, Options);
            File.WriteAllText(filePath, json);
        }

        public static void ImportFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File không tồn tại", filePath);

            var json = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<AppData>(json, Options);

            if (data == null) throw new Exception("JSON không hợp lệ hoặc rỗng");

            DataStore.Students.Clear();
            foreach (var s in data.Students) DataStore.Students.Add(s);

            DataStore.Teachers.Clear();
            foreach (var t in data.Teachers) DataStore.Teachers.Add(t);

            DataStore.Classes.Clear();
            foreach (var c in data.Classes) DataStore.Classes.Add(c);

            DataStore.NextStudentId = data.NextStudentId;
            DataStore.NextTeacherId = data.NextTeacherId;
            DataStore.NextClassId = data.NextClassId;
        }
    }
}
