using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Project
{
    public partial class FrmHome : Form
    {
        private Person _person;
        private TransportationEnum _choiceTransportation;
        private AccomodationEnum _choiceAccomodation;
        public FrmHome(Person person)
        {
            InitializeComponent();
            this._person = person;
        }


        private void addTransportation(ITransportation transportation)
        {
            transportation.Date = dateTimePicker1.Value;
            string[] row = { transportation.Date.ToString("dd'-'MM'-'yyyy"), transportation.Price.ToString(),transportation.IsWindowSide.ToString(),transportation.LuggageCapacity.ToString(),transportation.TravelTime.ToString()};
            ListViewItem listViewItem = new ListViewItem(row);
            
            listView1.Items.Add(listViewItem);
            
        }

        private void addHotel(Hotel hotel)
        {
            hotel.Date = dateTimePicker1.Value;
            string[] row = { hotel.Date.ToString("dd'-'MM'-'yyyy"), hotel.Capacity.ToString(), hotel.Price.ToString(),    hotel.StarCount.ToString(), hotel.Name.ToString(), hotel.Address.ToString() };
            ListViewItem listViewItem = new ListViewItem(row);

            listViewHotel.Items.Add(listViewItem);
            
        }

        private void addTent(Tent tent)
        {
            tent.Date = dateTimePicker1.Value;
            string[] row = { tent.Date.ToString("dd'-'MM'-'yyyy") , tent.Price.ToString(), tent.Capacity.ToString(), tent.IsWaterProof.ToString(),};
            ListViewItem listViewItem = new ListViewItem(row);

            listViewTent.Items.Add(listViewItem);
        }


        private void deletelistview()
        {
            listView1.Items.Clear();
            listViewHotel.Items.Clear();
            listViewTent.Items.Clear();
        }


        private void btnGöster_Click(object sender, EventArgs e)
        {
            deletelistview();
            _choiceTransportation = (TransportationEnum)comboBoxTransportation.SelectedIndex;
            _choiceAccomodation = (AccomodationEnum)comboBoxAccomodation.SelectedIndex;
            showData(_choiceTransportation, _choiceAccomodation);

        }

        private void showData(TransportationEnum transportationType, AccomodationEnum accomodationType)
        {
            if (transportationType == TransportationEnum.AIRPLANE)
            {
                foreach (Airplane airplane in Airplane.AirplaneList)
                {
                    addTransportation(airplane);
                }
            }
            else if (transportationType == TransportationEnum.BUS)
            {
                foreach (Bus bus in Bus.BusList)
                {
                    addTransportation(bus);
                }
            }

            if (accomodationType == AccomodationEnum.HOTEL)
            {
                foreach (Hotel hotel in Hotel.HotelList)
                {

                    addHotel(hotel);
                }
                listViewTent.Visible = false;
                listViewHotel.Visible = true;

            }
            else if (accomodationType == AccomodationEnum.TENT)
            {
                foreach (Tent tent in Tent.TentList)
                {

                    addTent(tent);
                }
                listViewTent.Visible = true;
                listViewHotel.Visible = false;
            }
        }
        private ITravelFactory getFactory()
        {
            ITravelFactory factory;
            if (_choiceAccomodation == AccomodationEnum.HOTEL)
            {
                Hotel hotel = Hotel.HotelList[listViewHotel.SelectedIndices[0]];
                if (_choiceTransportation == TransportationEnum.AIRPLANE)
                {
                    Airplane airplane = Airplane.AirplaneList[listView1.SelectedIndices[0]];
                    factory = new AirplaneHotelFactory(airplane, hotel);
                }
                else
                {
                    Bus bus = Bus.BusList[listView1.SelectedIndices[0]];
                    factory = new BusHotelFactory(bus, hotel);
                }
            }
            else
            {
                Tent tent = Tent.TentList[listViewTent.SelectedIndices[0]];
                if (_choiceTransportation == TransportationEnum.AIRPLANE)
                {
                    Airplane airplane = Airplane.AirplaneList[listView1.SelectedIndices[0]];
                    factory = new AirplaneTentFactory(airplane, tent);
                }
                else
                {
                    Bus bus = Bus.BusList[listView1.SelectedIndices[0]];
                    factory = new BusTentFactory(bus, tent);
                }
            }
            return factory;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ITravelFactory factory = getFactory();
           
            Travel travel = new Travel(factory, _person);
            FrmReport form3 = new FrmReport(travel);
            form3.Show();
            this.Hide();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            FrmLogin form1 = new FrmLogin();
            form1.Show();
            this.Hide();
        }
    }
}
