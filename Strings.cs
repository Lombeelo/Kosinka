﻿namespace KosinkaCore
{
	static class Strings
	{
		public const int CARD_HEIGHT = 12;
		public const int CARD_WIDTH = 13;

		public static string Win { get; } = "██─██──████──███──███────██──────███──████──████──███──████──████───█──█──█─█──███\n" +
											"─███───█──█───█───█─────█─█────────█──█──█──█──█───█───█──█──█──██──█─█───█─█────█\n" +
											"──█────█──█───█───███──█──█──────███──████──█──────█───████──████───██────███──███\n" +
											"─███───█──█───█───█────█──█────────█──█──█──█──█───█───█──█──█──██──█─█─────█─────\n" +
											"██─██──████───█───███──█──█──────███──█──█──████───█───█──█──████───█──█──███──█──\n" +
											"...................████████████████████████████████████████.......................\n" +
											"...................███████████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█████████.......................\n" +
											"...................███████▀▀░░░░░░░░░░░░░░░░░░░░░░░▀███████.......................\n" +
											"...................██████░░░░░░░░░░░░░░░░░░░░░░░░░░░▀██████.......................\n" +
											"...................█████▀░░░░▄▄▄▄░░░░░░▄▄▀███▄▄░░░░░░▀█████.......................\n" +
											"...................███▀░░░░░▀▀▀▀▀█▄░░░▀▄▄▀▀▀▀▀▀░░▄▄▄▄░▀▀███.......................\n" +
											"...................███░░░▀▀█▄▄░░░▄░░░░░░░░░░▀▀▀▀▀▀▄▄░▀▄░░██.......................\n" +
											"...................███▄░░░█░░░░▄█░░░░▄▄▀█░░░░░▄▄▀▀░█▀░█░░██.......................\n" +
											"...................████░░███▄▄░░░▀▄░░░░▄█▄▄▀▀▀█▄▄▄█▀░░░░███.......................\n" +
											"...................█████░███░█▀▀▀█▀▀█▀▀░░█▄▄▄██▀▄█░░░░█████.......................\n" +
											"...................█████░████████████████▀█▀░░▄█▀░░░░██████.......................\n" +
											"...................█████░▀██▀█▀█▀█▀▀▀█░░░░█▄▄▀▀░░░░▄███████.......................\n" +
											"...................████▀░░░▀▀█▄█▄▄▄▄▄█▄▄█▀▀▀░░░░░▄█████████.......................\n" +
											"...................████░░░░░░░░░░░░░░░░░░░░░░▄▄████████████.......................\n" +
											"...................████▄░░░░░░░░░░░░░░░░░▄█████████████████.......................\n" +
											"...................█████▄▄▄░░░░░▄▄▄▄███████████████████████.......................\n" +
											"...................████████████████████████████████████████.......................\n" +
											"──────────────────────────────────────────────────────────██──────────────────────\n" +
											"─────────────████──────████───████──███──────██─██──█─█──█──█──█──────────────────\n" +
											"─────────────█──█──────█──██──█──█───█────────███───█─█──█──█──█──────────────────\n" +
											"─────────────████──────████───█──█───█─────────█────███──█─██──█──────────────────\n" +
											"─────────────█──█──────█──██──█──█───█────────███─────█──██─█─────────────────────\n" +
											"─────────────█──█──────████───████───█───────██─██──███──█──█──█──────────────────\n";
		public static string CardValues { get; } = "A234567890JLK";
		public static string Suits { get; } = "♦♣♥♠";
		public static string[] FlippedCard { get; } =
		{
			" ___________ ",
			"|\\/\\/\\/\\/\\/\\|",
			"|/\\/\\/\\/\\/\\/|",
			"|\\/\\/\\/\\/\\/\\|",
			"|/\\/\\/\\/\\/\\/|",
			"|\\/\\/\\/\\/\\/\\|",
			"|/\\/\\/\\/\\/\\/|",
			"|\\/\\/\\/\\/\\/\\|",
			"|/\\/\\/\\/\\/\\/|",
			"|\\/\\/\\/\\/\\/\\|",
			"|/\\/\\/\\/\\/\\/|",
			"|___________|"
		};
		public static string[] EmptyCard { get; } =
		{
			" ___________ ",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|           |",
			"|___________|"
		};
		public static string[] EmptyDeck { get; } =
	   {
			"┌───────────┐",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"│           │",
			"└───────────┘"
		};
	}

	enum StackType
	{
		NOTHING,
		ACES_STACK,
		DECK,
		NEAR_DECK,
		NORMAL,
	}
}