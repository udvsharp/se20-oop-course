using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core;
using Core.IO;
using Model;

namespace UI
{
    public partial class MainForm : Form
    {
        private IOHandler _dataIo;
        private IOHandler _passedIo;
        private IOHandler _interviewIo;
        private IOHandler _conflictIo;
        private EntrantList _list;

        private const int INFO_CELL_ID = 0;
        private const int EXAM1_CELL_ID = 1;
        private const int EXAM2_CELL_ID = 2;
        private const int EXAM3_CELL_ID = 3;
        private const int CERTIFICATE_CELL_ID = 4;
        private const int CONTRACT_CELL_ID = 5;
        private const int BIRTH_DATE_CELL_ID = 6;
        private const int RATING_CELL_ID = 7;
        private const int PHONE_NUMBER_CELL_ID = 8;

        public MainForm()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs eargs)
        {
            Save();

            double minRating = Convert.ToDouble(minRatingInput.Value);
            int count = Convert.ToInt32(passedCountInput.Value);
            count = count > _list.Count ? _list.Count : count;

            var sortedByRating = _list.OrderBy(o => CalculateRating(o.Grades)).Reverse().ToList();
            var passed = _list.Take(count).ToList();
            var notPassed = _list.Skip(count).Take(_list.Count - count).ToList();
            var toInterview = notPassed
                .FindAll(entrant => CalculateRating(entrant.Grades) > minRating && !entrant.AgreesToContract)
                .ToList();
            var conflicts = sortedByRating.FindAll(entrant =>
                CalculateRating(entrant.Grades).Equals(CalculateRating(passed[^1].Grades)));

            _passedIo.SaveList(passed);
            _interviewIo.SaveList(toInterview);
            _conflictIo.SaveList(conflicts);
        }

        private void Save()
        {
            RecalculateRating();
            UpdateData();
            _list.Save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void recalculateButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void UpdateData()
        {
            _list = new EntrantList(_list.IoHandler);
            foreach (DataGridViewRow row in listDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] info = Convert.ToString(row.Cells[INFO_CELL_ID].Value)?.Split(' ');
                    if (info == null)
                    {
                        info = new[] {"Invalid Data", "Invalid Data", "Invalid Data"};
                    }

                    if (info.Length >= 3)
                    {
                        var e = new Entrant(
                            new EntrantInfo(
                                info[0],
                                info[1],
                                info[2],
                                Convert.ToDateTime(row.Cells[BIRTH_DATE_CELL_ID].Value),
                                Convert.ToString(row.Cells[PHONE_NUMBER_CELL_ID].Value)
                            ),
                            new Grades(
                                Convert.ToInt32(row.Cells[EXAM1_CELL_ID].Value),
                                Convert.ToInt32(row.Cells[EXAM2_CELL_ID].Value),
                                Convert.ToInt32(row.Cells[EXAM3_CELL_ID].Value),
                                Convert.ToDouble(row.Cells[CERTIFICATE_CELL_ID].Value)
                            ),
                            Convert.ToBoolean(row.Cells[CONTRACT_CELL_ID].Value)
                        );
                        _list.Add(e);
                    }
                    else
                    {
                        Console.WriteLine($@"{info} - Invalid Entrant Info");
                    }
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // setup
            _dataIo = new FileIOHandler(Core.Constants.DATA_FILE_NAME, new JSONSerializer());
            _passedIo = new FileIOHandler(Core.Constants.EXPORT_PASSED_FILE_NAME, new JSONSerializer());
            _interviewIo = new FileIOHandler(Core.Constants.EXPORT_INTERVIEW_FILE_NAME, new JSONSerializer());
            _conflictIo = new FileIOHandler(Core.Constants.EXPORT_CONFLICT_FILE_NAME, new JSONSerializer());

            _list = new EntrantList(_dataIo);
            _list.Read();

            ReloadList();
        }

        private void ReloadList()
        {
            listDataGridView.Rows.Clear();

            // Setup views
            foreach (var v in _list)
            {
                listDataGridView.Rows.Add(
                    v.Info.ToString(),
                    v.Grades.Exam1, v.Grades.Exam2, v.Grades.Exam3, v.Grades.Certificate,
                    v.AgreesToContract,
                    v.Info.BirthDate.ToShortDateString(),
                    CalculateRating(v.Grades),
                    v.Info.PhoneNumber
                );
            }
        }

        double CalculateRating(Grades grades)
        {
            double e1 = Convert.ToDouble(exam1CInput.Value);
            double e2 = Convert.ToDouble(exam2CInput.Value);
            double e3 = Convert.ToDouble(exam3CInput.Value);
            double c = Convert.ToDouble(certificateCInput.Value);

            return grades.Apply(e1, e2, e3, c);
        }

        private void RecalculateRating()
        {
            foreach (DataGridViewRow v in listDataGridView.Rows)
            {
                v.Cells[RATING_CELL_ID].Value = CalculateRating(new Grades(
                    Convert.ToInt32(v.Cells[EXAM1_CELL_ID].Value),
                    Convert.ToInt32(v.Cells[EXAM2_CELL_ID].Value),
                    Convert.ToInt32(v.Cells[EXAM3_CELL_ID].Value),
                    Convert.ToDouble(v.Cells[CERTIFICATE_CELL_ID].Value)
                ));
            }
        }
    }
}