using System;
using System.Collections.ObjectModel;

namespace Chart_Zooming_and_Panning
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new ObservableCollection<Model>()
			{
				new Model( 161, 65 ), new Model( 150,  65 ), new Model(155,  65 ), new Model(160, 65 ),
				new Model( 148, 66 ), new Model( 145,  66 ), new Model(137,  66 ), new Model(138, 66 ),
				new Model( 162, 66 ), new Model( 166,  66 ), new Model(159,  66 ), new Model(151, 66 ),
				new Model( 180, 66 ), new Model( 181,  66 ), new Model(174,  66 ), new Model(159, 66 ),
				new Model( 151, 67 ), new Model( 148,  67 ), new Model(141,  67 ), new Model(145, 67 ),
				new Model( 165, 67 ), new Model( 168,  67 ), new Model(159,  67 ), new Model(183, 67 ),
				new Model( 188, 67 ), new Model( 187,  67 ), new Model(172,  67 ), new Model(193, 67 ),
				new Model( 153, 68 ), new Model( 153,  68 ), new Model(147,  68 ), new Model(163, 68 ),
				new Model( 174, 68 ), new Model( 173,  68 ), new Model(160,  68 ), new Model(191, 68 ),
				new Model( 131, 62 ), new Model( 140,  62 ), new Model(149,  62 ), new Model(115, 62 ),
				new Model( 164, 63 ), new Model( 162,  63 ), new Model(167,  63 ), new Model(146, 63 ),
				new Model( 150, 64 ), new Model( 141,  64 ), new Model(142,  64 ), new Model(129, 64 ),
				new Model( 159, 64 ), new Model( 158,  64 ), new Model(162,  64 ), new Model(136, 64 ),
				new Model( 176, 64 ), new Model( 170,  64 ), new Model(167,  64 ), new Model(144, 64 ),
				new Model( 143, 65 ), new Model( 137,  65 ), new Model(137,  65 ), new Model(140, 65 ),
				new Model( 182, 65 ), new Model( 168,  65 ), new Model(181,  65 ), new Model(165, 65 ),
				new Model( 214, 74 ), new Model( 211,  74 ), new Model(166,  74 ), new Model(185, 74 ),
				new Model( 189, 68 ), new Model( 182,  68 ), new Model(181,  68 ), new Model(196, 68 ),
				new Model( 152, 69 ), new Model( 173,  69 ), new Model(190,  69 ), new Model(161, 69 ),
				new Model( 173, 69 ), new Model( 185,  69 ), new Model(141,  69 ), new Model(149, 69 ),
				new Model( 134, 62 ), new Model( 183,  62 ), new Model(155,  62 ), new Model(164, 62 ),
				new Model( 169, 62 ), new Model( 122,  62 ), new Model(161,  62 ), new Model(166, 62 ),
				new Model( 137, 63 ), new Model( 140,  63 ), new Model(140,  63 ), new Model(126, 63 ),
				new Model( 150, 63 ), new Model( 153,  63 ), new Model(154,  63 ), new Model(139, 63 ),
				new Model( 186, 69 ), new Model( 188,  69 ), new Model(148,  69 ), new Model(174, 69 ),
				new Model( 164, 70 ), new Model( 182,  70 ), new Model(200,  70 ), new Model(151, 70 ),
				new Model( 204, 74 ), new Model( 177,  74 ), new Model(194,  74 ), new Model(212, 74 ),
				new Model( 162, 70 ), new Model( 200,  70 ), new Model(166,  70 ), new Model(177, 70 ),
				new Model( 188, 70 ), new Model( 156,  70 ), new Model(175,  70 ), new Model(191, 70 ),
				new Model( 174, 71 ), new Model( 187,  71 ), new Model(208,  71 ), new Model(166, 71 ),
				new Model( 150, 71 ), new Model( 194,  71 ), new Model(157,  71 ), new Model(183, 71 ),
				new Model( 204, 71 ), new Model( 162,  71 ), new Model(179,  71 ), new Model(196, 71 ),
				new Model( 170, 72 ), new Model( 184,  72 ), new Model(197,  72 ), new Model(162, 72 ),
				new Model( 177, 72 ), new Model( 203,  72 ), new Model(159,  72 ), new Model(178, 72 ),
				new Model( 198, 72 ), new Model( 167,  72 ), new Model(184,  72 ), new Model(201, 72 ),
				new Model( 167, 73 ), new Model( 178,  73 ), new Model(215,  73 ), new Model(207, 73 ),
				new Model( 172, 73 ), new Model( 204,  73 ), new Model(162,  73 ), new Model(182, 73 ),
				new Model( 201, 73 ), new Model( 172,  73 ), new Model(189,  73 ), new Model(206, 73 ),
				new Model( 150, 74 ), new Model( 187,  74 ), new Model(153,  74 ), new Model(171, 74 ),
			};

		}
	}
}
