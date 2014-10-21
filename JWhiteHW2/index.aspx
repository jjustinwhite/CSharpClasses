<%@Page Language="C#"%>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
    <link rel="stylesheet" href="Style/main.css" type="text/css">
	<title>JWhiteHW2: Classes</title>
	<script runat="server" language="C#">
		void Page_Load()
		{

            JWhiteHW2.USCalendar cal = new JWhiteHW2.USCalendar();
            
            

            //output current date/time
            lblResults.Text = lblResults.Text + "The current Date/Time is: " + DateTime.Now + "<br/> ";
            
            //output string if weekend/weekday
            if (cal.isTodayInWeekend())
            {
                lblResults.Text = lblResults.Text + "<br/>'<b>Its the freakin weekend baby</b> Im about to have me some fun!' <i>-R Kelly</i>";
            }
            else 
            {
                lblResults.Text = lblResults.Text + "<br/><b>Its the weekday.</b> 'Woke up, fell out of bed. <br/>Dragged a comb across my head. <br/> Found my way downstairs and drank a cup <br/> And looking up I noticed I was late.' <i>-The Beatles</i> </br>";

            }
            
            //output string if leap year or not
            if (cal.isCurrentYearLeapYear())
            {
                lblResults.Text = lblResults.Text + "<br/>Ribbit. Ribbit. It's a leap year! 366 days this year.<br/>";
            }
            else
            {
                lblResults.Text = lblResults.Text + "<br/>Not a leap year! Still 365 days this year.<br/>";
            }

            //output number of days in the current month
            lblResults.Text = lblResults.Text + "<br/>Number of days in current month: " + cal.totalDaysInMonth() + ".<br/>";
            
            //output holiday name
            lblResults.Text = lblResults.Text + "<br/>Month: " + cal.getTodayHolidayName();
			
		}
		
		
		
	</script>
</head>

<body>
	<div id="mainBody">
		<header>
			<hgroup>
				<h1>JWhiteHW2: Classes</h1>
			</hgroup>
		</header>
		<section>
				<asp:Label runat="server" ID="lblResults"></asp:Label>
		</section>
		<footer>
		</footer>
	</div>
</body>
</html>