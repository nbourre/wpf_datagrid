using data_models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace datagrid_RowDetailsTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Customer> customers;

        public ObservableCollection<Customer> Customers { 
            get => customers;
            set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            InitValues();
        }

        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>()
            {
                new Customer() {Name="Ayanna", LastName="Vargas",Address="401-3122 Nullam Ave", City="Pickering",Province="ON", PostalCode="N6C 7M5", PicturePath="images/user.png", ContactInfo="Work : 624-767-4994"},
                new Customer() {Name="Whitney", LastName="Parks",Address="563-3207 Mi Rd.", City="Greater Sudbury",Province="ON", PostalCode="N9G 5V1", PicturePath="images/user.png", ContactInfo="Cell : 175-370-4839"},
                new Customer() {Name="Louis", LastName="Watts",Address="P.O. Box 529, 6291 Aliquam Road", City="Fredericton",Province="NB", PostalCode="E2T 4M4", PicturePath="images/user.png", ContactInfo="Cell : 734-499-0531"},
                new Customer() {Name="Pamela", LastName="Knapp",Address="2425 Urna Road", City="Mission",Province="BC", PostalCode="V6W 1J0", PicturePath="images/user.png", ContactInfo="Home : 510-433-5623"},
                new Customer() {Name="Clinton", LastName="Gallagher",Address="Ap #150-7450 Sapien Rd.", City="Scarborough",Province="ON", PostalCode="M5V 7N1", PicturePath="images/user.png", ContactInfo="Home : 328-524-0475"},
                new Customer() {Name="Amal", LastName="Cross",Address="P.O. Box 738, 9025 Sed Street", City="Parkland County",Province="AB", PostalCode="T6S 6A4", PicturePath="images/user.png", ContactInfo="Cell : 250-555-4617"},
                new Customer() {Name="Vanna", LastName="Hyde",Address="5671 Eros Rd.", City="Daly",Province="MB", PostalCode="R0E 5T0", PicturePath="images/user.png", ContactInfo="Email : Quisque@neque.net"},
                new Customer() {Name="Madonna", LastName="Navarro",Address="P.O. Box 647, 5331 Erat, Rd.", City="Prince George",Province="BC", PostalCode="V6Y 0X2", PicturePath="images/user.png", ContactInfo="Home : 369-993-0222"},
                new Customer() {Name="Rina", LastName="Decker",Address="138-7714 Orci, St.", City="Hamilton",Province="ON", PostalCode="L7Z 9Z5", PicturePath="images/user.png", ContactInfo="Work : 140-464-7242"},
                new Customer() {Name="Dustin", LastName="Cole",Address="531-6134 Ut St.", City="St. Thomas",Province="ON", PostalCode="K1C 9L0", PicturePath="images/user.png", ContactInfo="Email : eget.dictum@Aliquamvulputate.ca"},
                new Customer() {Name="Kellie", LastName="Hanson",Address="6655 Integer Avenue", City="Windsor",Province="ON", PostalCode="P5Y 0S4", PicturePath="images/user.png", ContactInfo="Work : 175-412-9657"},
                new Customer() {Name="Cain", LastName="Booth",Address="P.O. Box 733, 4514 Id Road", City="Rimouski",Province="QC", PostalCode="J7Y 1R5", PicturePath="images/user.png", ContactInfo="Cell : 668-418-2708"},
                new Customer() {Name="Todd", LastName="Christian",Address="8576 A Av.", City="Smoky Lake",Province="AB", PostalCode="T7W 1W6", PicturePath="images/user.png", ContactInfo="Cell : 401-455-7531"},
                new Customer() {Name="Hashim", LastName="Hodge",Address="800-2799 Phasellus Street", City="Sunset Point",Province="AB", PostalCode="T7K 1L3", PicturePath="images/user.png", ContactInfo="Home : 108-300-4964"},
                new Customer() {Name="Leah", LastName="Miller",Address="P.O. Box 716, 6477 Fringilla Rd.", City="Shawinigan",Province="QC", PostalCode="J8Y 2A2", PicturePath="images/user.png", ContactInfo="Cell : 408-758-5810"},
                new Customer() {Name="Kenneth", LastName="Roberts",Address="Ap #173-2146 Ac Street", City="Swan Hills",Province="AB", PostalCode="T3X 8M7", PicturePath="images/user.png", ContactInfo="Home : 122-178-1426"},
                new Customer() {Name="Carly", LastName="Christensen",Address="773-7929 Dapibus Av.", City="Legal",Province="AB", PostalCode="T2C 7N9", PicturePath="images/user.png", ContactInfo="Home : 386-338-5818"},
                new Customer() {Name="Malik", LastName="Compton",Address="7436 Arcu St.", City="Cap-Rouge",Province="QC", PostalCode="J4V 0H1", PicturePath="images/user.png", ContactInfo="Cell : 369-993-0222"},
                new Customer() {Name="Victoria", LastName="King",Address="261-9542 Luctus Rd.", City="Whitchurch-Stouffville",Province="ON", PostalCode="K8N 2G7", PicturePath="images/user.png", ContactInfo="Home : 550-230-2146"},
                new Customer() {Name="James", LastName="Simon",Address="4628 Enim. Av.", City="Chilliwack",Province="BC", PostalCode="V3Z 2J1", PicturePath="images/user.png", ContactInfo="Cell : 343-151-5411"},
                new Customer() {Name="Christopher", LastName="Monroe",Address="8142 Fusce St.", City="Baie-Comeau",Province="QC", PostalCode="G2B 9R9", PicturePath="images/user.png", ContactInfo="Work : 827-654-9939"},
                new Customer() {Name="Bradley", LastName="Ramsey",Address="509-4890 Elit. Rd.", City="Ramara",Province="ON", PostalCode="P6Z 0R2", PicturePath="images/user.png", ContactInfo="Cell : 667-760-4209"},
                new Customer() {Name="Yoshi", LastName="West",Address="895-5927 Vitae, Avenue", City="Calder",Province="SK", PostalCode="S8A 4L6", PicturePath="images/user.png", ContactInfo="Cell : 966-522-0442"},
                new Customer() {Name="May", LastName="Frye",Address="3295 Diam Rd.", City="Whitewater Region Township",Province="ON", PostalCode="N6P 0S4", PicturePath="images/user.png", ContactInfo="Email : consectetuer.euismod@adipiscingelit.net"},
                new Customer() {Name="Madeline", LastName="Mclaughlin",Address="5004 Nisi. Av.", City="Edmundston",Province="NB", PostalCode="E2N 6G0", PicturePath="images/user.png", ContactInfo="Email : Sed.dictum@Crasegetnisi.org"},
                new Customer() {Name="Eaton", LastName="Wilson",Address="P.O. Box 934, 9939 Fringilla St.", City="Qualicum Beach",Province="BC", PostalCode="V5X 1K4", PicturePath="images/user.png", ContactInfo="Email : Quisque@neque.net"},
                new Customer() {Name="Scott", LastName="Simpson",Address="P.O. Box 254, 5253 Phasellus Road", City="St. Catharines",Province="ON", PostalCode="P1C 0M2", PicturePath="images/user.png", ContactInfo="Home : 310-470-5590"},
                new Customer() {Name="Jenette", LastName="Michael",Address="483-1483 Aliquam St.", City="Fort St. John",Province="BC", PostalCode="V5L 7S2", PicturePath="images/user.png", ContactInfo="Home : 126-931-8145"},
                new Customer() {Name="Idona", LastName="Humphrey",Address="6027 Suspendisse Street", City="Silverton",Province="BC", PostalCode="V1K 6W9", PicturePath="images/user.png", ContactInfo="Cell : 883-996-7263"},
                new Customer() {Name="Erin", LastName="Mcguire",Address="P.O. Box 576, 5350 Ligula Rd.", City="Coquitlam",Province="BC", PostalCode="V4S 0J3", PicturePath="images/user.png", ContactInfo="Work : 827-654-9939"},
                new Customer() {Name="Cooper", LastName="Mejia",Address="983-3119 Nulla Rd.", City="Watson Lake",Province="YT", PostalCode="Y3A 1T0", PicturePath="images/user.png", ContactInfo="Home : 319-112-3705"},
                new Customer() {Name="Skyler", LastName="Whitaker",Address="P.O. Box 713, 995 Dolor Ave", City="Kawartha Lakes",Province="ON", PostalCode="K9Y 9L4", PicturePath="images/user.png", ContactInfo="Cell : 175-412-9657"},
                new Customer() {Name="Anastasia", LastName="Garza",Address="Ap #688-1154 Vulputate St.", City="Collines-de-l'Outaouais",Province="QC", PostalCode="H1K 1X1", PicturePath="images/user.png", ContactInfo="Home : 310-470-5590"},
                new Customer() {Name="Tana", LastName="Walton",Address="P.O. Box 128, 6980 Lacus. Avenue", City="Windsor",Province="ON", PostalCode="P8Z 0B4", PicturePath="images/user.png", ContactInfo="Cell : 759-388-6783"},
                new Customer() {Name="Tatum", LastName="Montoya",Address="P.O. Box 447, 4276 Ipsum Road", City="Winnipeg",Province="MB", PostalCode="R9C 0R2", PicturePath="images/user.png", ContactInfo="Work : 624-767-4994"},
                new Customer() {Name="Tanek", LastName="Jefferson",Address="7419 Vestibulum. Street", City="Windsor",Province="ON", PostalCode="P3A 6J6", PicturePath="images/user.png", ContactInfo="Work : 175-412-9657"},
                new Customer() {Name="Zia", LastName="Barber",Address="P.O. Box 109, 3316 Lacus St.", City="Osgoode",Province="ON", PostalCode="N8X 5X2", PicturePath="images/user.png", ContactInfo="Cell : 122-178-1426"},
                new Customer() {Name="Alvin", LastName="Ferguson",Address="P.O. Box 345, 4329 Pede. St.", City="Montebello",Province="QC", PostalCode="G4N 7Z3", PicturePath="images/user.png", ContactInfo="Email : et.pede@intempus.edu"},
                new Customer() {Name="Rhea", LastName="Ewing",Address="Ap #196-9632 Elit. Rd.", City="Notre-Dame-de-la-Salette",Province="QC", PostalCode="G5R 3W3", PicturePath="images/user.png", ContactInfo="Cell : 570-950-7912"},
                new Customer() {Name="Jelani", LastName="Sims",Address="Ap #656-4632 Sem St.", City="Bruderheim",Province="AB", PostalCode="T3L 9V3", PicturePath="images/user.png", ContactInfo="Home : 122-178-1426"},
                new Customer() {Name="Clare", LastName="Sanders",Address="Ap #624-7905 Egestas. St.", City="Saint-Prime",Province="QC", PostalCode="G7K 4Z1", PicturePath="images/user.png", ContactInfo="Home : 349-514-9365"},
                new Customer() {Name="Cadman", LastName="Howell",Address="Ap #667-4310 Gravida Avenue", City="Sooke",Province="BC", PostalCode="V8X 0P9", PicturePath="images/user.png", ContactInfo="Cell : 501-312-8343"},
                new Customer() {Name="Camilla", LastName="Warren",Address="3287 Mauris Avenue", City="Vanier",Province="ON", PostalCode="K9E 2A4", PicturePath="images/user.png", ContactInfo="Cell : 658-774-3123"},
                new Customer() {Name="Lester", LastName="Castillo",Address="P.O. Box 734, 9979 Neque St.", City="Milestone",Province="SK", PostalCode="S6X 4Y9", PicturePath="images/user.png", ContactInfo="Work : 956-952-7149"},
                new Customer() {Name="Denton", LastName="Ashley",Address="P.O. Box 646, 4903 Ante Avenue", City="Rivière-du-Loup",Province="QC", PostalCode="H4T 3R7", PicturePath="images/user.png", ContactInfo="Work : 490-990-4981"},
                new Customer() {Name="Kennan", LastName="Hebert",Address="9014 Nisi. Av.", City="Township of Minden Hills",Province="ON", PostalCode="M5J 5S5", PicturePath="images/user.png", ContactInfo="Work : 750-521-7193"},
                new Customer() {Name="Kelly", LastName="Alexander",Address="117-838 Venenatis Rd.", City="Wrigley",Province="NT", PostalCode="X9X 3R8", PicturePath="images/user.png", ContactInfo="Email : dui.nec@quismassa.co.uk"},
                new Customer() {Name="Felicia", LastName="Wright",Address="248-9794 Scelerisque Avenue", City="Kingston",Province="ON", PostalCode="L5Y 0B9", PicturePath="images/user.png", ContactInfo="Home : 319-112-3705"},
                new Customer() {Name="Fleur", LastName="Luna",Address="P.O. Box 931, 3838 Magna Road", City="Thunder Bay",Province="ON", PostalCode="P7J 6V5", PicturePath="images/user.png", ContactInfo="Email : mi@massaSuspendisseeleifend.edu"},
                new Customer() {Name="Patience", LastName="Barnett",Address="660-2038 Sagittis St.", City="Scarborough",Province="ON", PostalCode="L7L 4M3", PicturePath="images/user.png", ContactInfo="Work : 956-952-7149"},
                new Customer() {Name="Gil", LastName="Jacobs",Address="2368 Per Street", City="Nanaimo",Province="BC", PostalCode="V1H 0S3", PicturePath="images/user.png", ContactInfo="Cell : 490-990-4981"},
                new Customer() {Name="Brennan", LastName="Kent",Address="7723 Tristique St.", City="Greater Sudbury",Province="ON", PostalCode="M9L 3P6", PicturePath="images/user.png", ContactInfo="Email : consectetuer.euismod@adipiscingelit.net"},
                new Customer() {Name="Wang", LastName="Patel",Address="973-3669 Nulla Road", City="Delta",Province="BC", PostalCode="V2B 7Y5", PicturePath="images/user.png", ContactInfo="Work : 532-155-0355"},
                new Customer() {Name="Kendall", LastName="Sosa",Address="7782 Lacus. Road", City="Owen Sound",Province="ON", PostalCode="M0A 2J6", PicturePath="images/user.png", ContactInfo="Work : 819-218-3780"},
                new Customer() {Name="Chava", LastName="Contreras",Address="2298 Erat, Av.", City="Thunder Bay",Province="ON", PostalCode="M1C 8H0", PicturePath="images/user.png", ContactInfo="Work : 296-427-2849"},
                new Customer() {Name="Norman", LastName="Lambert",Address="181-4832 Nunc St.", City="Beausejour",Province="MB", PostalCode="R6V 6K8", PicturePath="images/user.png", ContactInfo="Work : 750-521-7193"},
                new Customer() {Name="Leroy", LastName="Johnson",Address="Ap #987-1031 Pede Ave", City="Airdrie",Province="AB", PostalCode="T2X 5Y9", PicturePath="images/user.png", ContactInfo="Home : 122-178-1426"},
                new Customer() {Name="Holmes", LastName="Goff",Address="473-7295 Lacus Ave", City="Greater Sudbury",Province="ON", PostalCode="L4B 6M3", PicturePath="images/user.png", ContactInfo="Cell : 972-152-1647"},
                new Customer() {Name="Hayden", LastName="Blackwell",Address="P.O. Box 454, 7536 Nulla Avenue", City="Fermont",Province="QC", PostalCode="J9H 4M4", PicturePath="images/user.png", ContactInfo="Email : id.ante@lacusEtiambibendum.org"},
                new Customer() {Name="Reece", LastName="Burton",Address="3891 Ullamcorper. Road", City="Carleton",Province="QC", PostalCode="G5V 8B0", PicturePath="images/user.png", ContactInfo="Email : dis.parturient@sociis.net"},
                new Customer() {Name="Ryder", LastName="Franklin",Address="P.O. Box 538, 5007 Sed Avenue", City="Daly",Province="MB", PostalCode="R8N 9M0", PicturePath="images/user.png", ContactInfo="Home : 165-365-4117"},
                new Customer() {Name="Noah", LastName="Meyer",Address="Ap #962-8193 Sit St.", City="Nakusp",Province="BC", PostalCode="V3J 3Y2", PicturePath="images/user.png", ContactInfo="Work : 380-642-0319"},
                new Customer() {Name="Zorita", LastName="Carlson",Address="379-6708 Neque. St.", City="Daly",Province="MB", PostalCode="R9T 4H7", PicturePath="images/user.png", ContactInfo="Email : eget@etpede.com"},
                new Customer() {Name="Leroy", LastName="Haney",Address="5711 Ligula St.", City="East Gwillimbury",Province="ON", PostalCode="K8T 2K8", PicturePath="images/user.png", ContactInfo="Home : 122-178-1426"},
                new Customer() {Name="Warren", LastName="Page",Address="Ap #713-4439 Natoque Ave", City="Picture Butte",Province="AB", PostalCode="T5V 0X7", PicturePath="images/user.png", ContactInfo="Email : lectus.a@metussit.edu"},
                new Customer() {Name="Zia", LastName="Higgins",Address="Ap #523-1867 Eget, Rd.", City="Norfolk County",Province="ON", PostalCode="K0T 3B5", PicturePath="images/user.png", ContactInfo="Cell : 250-555-4617"},
                new Customer() {Name="Zachary", LastName="Maxwell",Address="P.O. Box 953, 4234 Nisi Street", City="Salt Spring Island",Province="BC", PostalCode="V6A 0Y2", PicturePath="images/user.png", ContactInfo="Email : hymenaeos.Mauris@malesuadaaugue.ca"},
                new Customer() {Name="Brianna", LastName="Oneill",Address="Ap #558-4367 Pellentesque Av.", City="Grande Cache",Province="AB", PostalCode="T6Z 3B3", PicturePath="images/user.png", ContactInfo="Home : 706-533-5060"},
                new Customer() {Name="Phyllis", LastName="Mcgowan",Address="P.O. Box 537, 9998 Ut, Av.", City="Valcourt",Province="QC", PostalCode="J8K 0H2", PicturePath="images/user.png", ContactInfo="Cell : 624-767-4994"},
                new Customer() {Name="Lucius", LastName="Blevins",Address="P.O. Box 399, 7690 Sodales Road", City="Chambord",Province="QC", PostalCode="H6B 8E2", PicturePath="images/user.png", ContactInfo="Email : purus.in@semvitae.edu"},
                new Customer() {Name="Chase", LastName="Sears",Address="Ap #163-4569 Nibh St.", City="Minitonas",Province="MB", PostalCode="R9L 9R5", PicturePath="images/user.png", ContactInfo="Email : lectus.a@metussit.edu"},
                new Customer() {Name="Flynn", LastName="Gardner",Address="8362 Sed Road", City="Daly",Province="MB", PostalCode="R2V 5E7", PicturePath="images/user.png", ContactInfo="Home : 126-931-8145"},
                new Customer() {Name="Sebastian", LastName="Byers",Address="3034 Purus Avenue", City="Grande Cache",Province="AB", PostalCode="T1P 9K1", PicturePath="images/user.png", ContactInfo="Cell : 319-112-3705"},
                new Customer() {Name="Dale", LastName="Cantrell",Address="Ap #157-9162 Et, Road", City="Amqui",Province="QC", PostalCode="J9G 9B4", PicturePath="images/user.png", ContactInfo="Email : mauris@mauris.net"},
                new Customer() {Name="Stacey", LastName="Clements",Address="Ap #630-4776 Hendrerit St.", City="Barrie",Province="ON", PostalCode="K8G 9B5", PicturePath="images/user.png", ContactInfo="Work : 773-187-5827"},
                new Customer() {Name="Amy", LastName="Gay",Address="5253 Libero. Ave", City="Miramichi",Province="NB", PostalCode="E2B 9K9", PicturePath="images/user.png", ContactInfo="Home : 605-414-3547"},
                new Customer() {Name="Joel", LastName="Rollins",Address="P.O. Box 507, 793 Adipiscing Rd.", City="Etobicoke",Province="ON", PostalCode="N3W 8Y4", PicturePath="images/user.png", ContactInfo="Work : 684-528-9015"},
                new Customer() {Name="Wilma", LastName="Noel",Address="P.O. Box 849, 2845 In Road", City="Norman Wells",Province="NT", PostalCode="X7P 9A1", PicturePath="images/user.png", ContactInfo="Email : tincidunt.neque.vitae@sagittisDuisgravida.org"},
                new Customer() {Name="Quamar", LastName="Bender",Address="Ap #341-5146 Ac Rd.", City="Whitehorse",Province="YT", PostalCode="Y6E 5Z9", PicturePath="images/user.png", ContactInfo="Work : 961-981-3934"},
                new Customer() {Name="Kimberly", LastName="Saunders",Address="Ap #234-9382 In, Rd.", City="Calder",Province="SK", PostalCode="S6A 4S8", PicturePath="images/user.png", ContactInfo="Home : 966-522-0442"},
                new Customer() {Name="Madeline", LastName="Roman",Address="8931 Cursus Avenue", City="Montreal",Province="QC", PostalCode="J1G 6K3", PicturePath="images/user.png", ContactInfo="Home : 175-412-9657"},
                new Customer() {Name="Justina", LastName="Brady",Address="5311 Ornare Av.", City="Labrecque",Province="QC", PostalCode="G9K 9Y4", PicturePath="images/user.png", ContactInfo="Work : 140-464-7242"},
                new Customer() {Name="Marsden", LastName="Savage",Address="9245 Mollis Rd.", City="Port Hope",Province="ON", PostalCode="L0A 5B1", PicturePath="images/user.png", ContactInfo="Work : 175-412-9657"},
                new Customer() {Name="Austin", LastName="Weiss",Address="P.O. Box 940, 6937 Dolor Avenue", City="Newmarket",Province="ON", PostalCode="L8Y 4N1", PicturePath="images/user.png", ContactInfo="Cell : 126-931-8145"},
                new Customer() {Name="Stephanie", LastName="Alexander",Address="259-8236 Nulla. St.", City="Champlain",Province="QC", PostalCode="J2N 7L1", PicturePath="images/user.png", ContactInfo="Email : turpis.non@Donec.org"},
                new Customer() {Name="Pamela", LastName="Wise",Address="P.O. Box 728, 4756 At Rd.", City="Merrickville-Wolford",Province="ON", PostalCode="P9B 4X0", PicturePath="images/user.png", ContactInfo="Home : 386-338-5818"},
                new Customer() {Name="Austin", LastName="Lawson",Address="Ap #284-102 Eu, Avenue", City="Macklin",Province="SK", PostalCode="S9T 9Y5", PicturePath="images/user.png", ContactInfo="Email : hymenaeos.Mauris.ut@liberomaurisaliquam.org"},
                new Customer() {Name="Erasmus", LastName="Mendez",Address="P.O. Box 321, 7761 Dui. Street", City="Montpellier",Province="QC", PostalCode="H9Z 9V9", PicturePath="images/user.png", ContactInfo="Home : 467-635-9200"},
                new Customer() {Name="Camilla", LastName="Rodriquez",Address="8793 Eu Ave", City="Tay",Province="ON", PostalCode="M5B 7Z5", PicturePath="images/user.png", ContactInfo="Work : 408-758-5810"},
                new Customer() {Name="Orla", LastName="Larson",Address="219-2372 Habitant Street", City="Ramara",Province="ON", PostalCode="M3Z 3M5", PicturePath="images/user.png", ContactInfo="Email : hymenaeos.Mauris@malesuadaaugue.ca"},
                new Customer() {Name="Theodore", LastName="Green",Address="673 Mauris St.", City="Guelph",Province="ON", PostalCode="P3T 9P0", PicturePath="images/user.png", ContactInfo="Home : 122-178-1426"},
                new Customer() {Name="Hollee", LastName="Little",Address="P.O. Box 652, 5985 Massa. Road", City="Vanier",Province="ON", PostalCode="K6Z 6Y5", PicturePath="images/user.png", ContactInfo="Email : sem.Pellentesque@luctuslobortisClass.co.uk"},
                new Customer() {Name="Elaine", LastName="Gonzalez",Address="382-3309 Neque. Av.", City="Charlottetown",Province="PE", PostalCode="C1N 0K3", PicturePath="images/user.png", ContactInfo="Work : 956-952-7149"},
                new Customer() {Name="Winifred", LastName="England",Address="P.O. Box 637, 1690 Consectetuer Road", City="Mission",Province="BC", PostalCode="V2E 2K5", PicturePath="images/user.png", ContactInfo="Work : 750-521-7193"},
                new Customer() {Name="Vaughan", LastName="Summers",Address="965-9501 Auctor, Av.", City="Shawinigan",Province="QC", PostalCode="J8N 4G6", PicturePath="images/user.png", ContactInfo="Home : 108-300-4964"},
                new Customer() {Name="Dawn", LastName="Terry",Address="Ap #712-5570 Ullamcorper. Rd.", City="Renfrew",Province="ON", PostalCode="M4V 1N7", PicturePath="images/user.png", ContactInfo="Work : 491-865-6707"},
                new Customer() {Name="Martena", LastName="Henderson",Address="P.O. Box 790, 7814 In Rd.", City="Kawartha Lakes",Province="ON", PostalCode="M4T 4J9", PicturePath="images/user.png", ContactInfo="Work : 486-141-1305"},
                new Customer() {Name="Sheila", LastName="Nichols",Address="357-3278 Metus. Ave", City="Ajax",Province="ON", PostalCode="K4R 8M1", PicturePath="images/user.png", ContactInfo="Home : 535-812-9710"},
                new Customer() {Name="Castor", LastName="Ward",Address="9689 Sed Rd.", City="Bathurst",Province="NB", PostalCode="E3R 7Z5", PicturePath="images/user.png", ContactInfo="Cell : 328-524-0475"},
                new Customer() {Name="Randall", LastName="Griffith",Address="Ap #295-2152 Cras Street", City="Price",Province="QC", PostalCode="J3T 8R1", PicturePath="images/user.png", ContactInfo="Home : 108-300-4964"},

            };

        }
    }
}
