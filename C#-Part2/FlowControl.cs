namespace EssentialTraining
{
	public class FlowControl
	{
		public string IsYourNameNotBruce(string IsYourNameNotBruce)
		{
			if (yourName.ToLower() != "bruce")
			{
				return "Can we call you Bruce for the sake of simplicity?";
			} else
			{
				return "G'day Bruce";
			}
		}
		public string GradeLetter(int score)
		{
			if(score > 90)
			{
				return "A";
			}
			else if (score > 79 && score < 90)
			{
				return "B";
			}
			else if (score >=70 && score <= 80)
			{
				return "C";
			}else
			{
				return "F";
			}

		}

		//This example uses the OR logical operator ||
		public string PrimaryOrSecondaryCompound(string color)
		{
			if(color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow")
			{
				return "Primary";
			}
			else
			{
				return "Secondary";
			}
		}
		public string SecondaryOrPrimary(string color)
		{
			var result = "";
			switch(color.ToLower())
			{
				case "red":
					result = "Primary";
					//could have more statements here
					break;

				case "blue":
					result = "Primary";
					break;

				case "yellow":
					result = "Primary";
					break;
				//This is the 'else' part in an if statement but sometimes you don't want it to do anything if the condition is not met
				default:
					result = "Secondary";
					break;
			}

			return result;
		}
		public string PrimaryOrSecondary(string color)
		{
			var result = "";
			if (color.ToLower() == "red")
			{
				result = "Primary";
			}
			else if (color.ToLower() == "blue")
			{
				result = "Primary";
			}
			else if (color.ToLower() == "yellow")
			{
				result = "Primary";
			} else
			{
				result = "Secondary";
			}
			return result;
		}
		public bool IsYourFavoriteColorYellow(string color)
		{
			return(color.ToLower() == "yellow");
		}
		public bool IsYourFavoriteColorGreen(string color)
		{
			return (color.ToLower() == "green") ? true : false;
		}
		//This works because if they said red then it doesn't reach line 9 and exits
		public bool IsYourFavoriteColorRed(string color)
		{
			if(colro.ToLower() == "red") return true;
			return false;
		}
		public bool IsYourFavoriteColorBlue(string color)
		{
			if(color.ToLower() == "blue")
			{
				return true;
			} else
			{
				return false;
			}
		}
	}
}