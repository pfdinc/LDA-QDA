
![alt text](https://github.com/pfdinc/discriminant-_analysis_C_sharp/blob/master/photo/Screen%20Shot%202017-10-25%20at%2011.43.17%20PM.png)

 


## Author

* **Pushkin Feleke** - *Profile* - [Linkedin](https://www.linkedin.com/in/pushkin-feleke-649961b7/)
* Other Software projects located on  [*github*](https://github.com/pfdinc) 

## Definition - wikipedia
Liner / Quadratic Discreminant Analysis is a method statistics, pattern recognition and machine learning to find a linear combination of features that characterizes or separates two or more classes of objects or events.The resulting combination may be used as a linear classifier, or, more commonly, for dimensionality reduction before later classification.


## Running the tests
```
* chart.exe
```
```
Note: The result folder need to be placed with in the same directory 
* User result will be saved to the result.csv file  

Note: The following are defult plots for 2 and 4 classes 
* 2Classes_Default.csv
* 4Classes_Default.csv
```

## Structure 

![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/DA.png)

## Deployment

This is created and tested to work with 
```
Window 7+ 32Bit & 64Bit system 
```
## Built With

* [Visual Studio](https://www.visualstudio.com/vs/whatsnew/) - IDE
* [C# Guide](https://docs.microsoft.com/en-us/dotnet/csharp/) - C# programming Language 
* [Windows Forms](https://msdn.microsoft.com/en-us/library/system.windows.forms.form(v=vs.110).aspx) - graphical user interface application programming interface (API) 

##UI Instruction
```
NOTE: Make sure your result folder is in the same directory 
```

### *Step 1*
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.29.24%20PM.png)

```
This page is what you will see when you run the program 
* Discriminant Analysis >> Testing
* Visual Analysis >> Visual Analytics
* About >> Github documentation
* Exit >> Exits Program
```
### *Step 2*
```cs
>>Enter name where its prompted
>>Pick file to be presented onto the chart 
Note: Make sure the class you choose matches promp 
>>Submit>>To populate graph 
```
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.30.14%20PM.png)

```
>>> If you dont choose a .csv file >> 2Classes_Defult.csv & 4Classes_Defult.csv will populate the graph. 
```
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.30.48%20PM.png)

### *Step 3*

```
>>If you choose the right files the you will see the plots with in your graph.
>>If you cjoose a grph that is not valid, please exit and try step 2
>>You name will display on the left of the graph
>>Timer will start when the graph is displayed 
>> Submit >> Get result
```

![alt text](https://github.com/pfdinc/dLDA-QDA/blob/master/photo/Screen%20Shot%202017-10-26%20at%2011.07.15%20AM.png)

```
>> Drag the lines to seperate the 2 or 4 classes.
>> When you are done seperating the classes, the timer will atomatically stop
>> result will display with in the confusion matrix 
```
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-10-26%20at%2011.07.38%20AM.png)


### Buttons on the bottom 
```
>>> Restart testing >> take you back to step 2
>>> Visual Analysis >> Visual analytic web page
>>> About >> Github page for this software 
```
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-10-26%20at%2011.07.52%20AM.png)


## Confusion Matrix 

![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-10-26%20at%2011.07.44%20AM.png)



![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-10-26%20at%2011.06.29%20AM.png)


```
>> Prompt for first and last name, Proram will not run without user info.
>> 2 Class & 4 Class >> Locate file 
>> Submit once you have located a .csv file to analize

```

![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.30.48%20PM.png)

```
*	Pick classes based on the instruction follow sted 2

```

### *Step 4*
![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.31.13%20PM.png)

```
* Your Choice will display here 
```

# Implementation

#form1
### Form1_Load

```cs
Form1_Load(object sender, EventArgs e)
>> initialize when Form1 is loaded.
>> Define the border style of the form to a FixedSingle
>> Set the MaximizeBox to false to remove the maximize box.
>> Set the start position of the form to the center of the screen.
>> RESIZE THE TEXTBOX
>> change the font style & size
```
### textBox1_KeyDown

```cs
textBox1_KeyDown(object sender, KeyEventArgs e)
>> textbox for name 
```
### get_2classes_data

```cs
get_2classes_data()
>> get file name for inputting 2 class data
```
### get_4classes_data

```cs
get file name for inputting 4 class data
>>get file name for inputting 4 class data
>>occur when 2 class button is pressed
```

### get_2class_OnClick

```cs
get_2class_OnClick(Object sender, EventArgs e)
```
### get_4class_OnClick
```cs
get_4class_OnClick()
occur when 4 class button is pressed
```
### submit_OnClick

```cs
>> occur when submit button is pressed
>> set user name
>> 
```
## button4_Click

```cs
button4_Click()
>> this will exit application
```
### button5_Click
```cs
button5_Click()
>> this will take you back to the main page

```



# form2
### form2_load
```cs
  >>void Form2_Load(object sender, EventArgs e){}
  >>controls the colors for 4 class dividers
  >>initialize when Form2 is loaded.
  >>initialize when Form2 is loaded.
  >>Set the start position of the form to the center of the screen.
  >> controls the colors for 2 class dividers
  >>make the backgroung of lables transparent 
   
   
```
### input_points

```cs

>> void input_points(){}
>> input points' data for 2 classes
>> get the count of points for 2-class
>> Read 2-class point data from CSV file
>> input points' data for 4 classes
>> get the count of points for 4-class
>> Read 2-class point data from CSV file
```

### draw_class2_axis

```cs
private void draw_class2_axis(PaintEventArgs g){}
>> draw coordinate axis on 2 class graph
>> Create points that define line.
>> Draw axis to screen.
>> draw identification points for classes
>> 

```

### draw_class4_axis

```cs
>> private void draw_class4_axis(PaintEventArgs g)
>> draw coordinate axis on 4 class graph
>> Create points that define line.
>> draw identification points for classes for pints 1-4
```

### draw_2class_points

```cs
>>draw_2class_points(PaintEventArgs g)
>>draw points for 2 class 
>>draw class 1 points & transform coordinates
>>draw class 2 points & transform coordinates
```
###  draw_4class_points

```cs
>>draw_4class_points(PaintEventArgs g)
>>draw class 1 points & transform coordinates
>>draw class 2 points & transform coordinates
>>draw class 3 points & transform coordinates
>>draw class 4 points & transform coordinates
```
### timer_start

```cs
>>timer_start()
>> use winform's timer

```
### Timer 
The timer starts when the user begins the test, 

```cs
//start timer
        private void timer_start()
        {
            elapsed_time = 0;
            // use winform's timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // one second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
```


### class2_graph_OnMouseMove

```cs
>>	void class2_graph_OnMouseMove(Object sender, MouseEventArgs e)
>>	get the end point of line on class2 graph once user moves mouse
```
### class2_graph_OnMouseUp

```cs
>> get the end point of line on class2 graph once user release mouse's 	pressing
>> class2_graph_OnMouseUp(Object sender, MouseEventArgs e)
```

###  class2_graph_OnPaint

```cs
>> class2_graph_OnPaint(Object sender, PaintEventArgs e)
>> draw dividing line on class2 graph

				//This is where the color for the drag
            using (var pen = new Pen(Color.Black, 1.5F))
            {
                e.Graphics.DrawLine(pen, this.class2_MouseInitialPosition, 					this.class2_MouseLastPosition);
            }
```

### class4_graph_OnMouseDown

```cs
>> get the first point of line on class4 graph
```
### class4_graph_OnMouseMove
```cs
>> get the end point of line on class4 graph when mouse moves
```

### class4_graph_OnMouseUp
```cs
>> class4_graph_OnMouseUp(Object sender, MouseEventArgs e)
>> get the end point of line on class4 graph once user release mouse's 	pressing
```

### class4_graph_OnPaint

```cs
>>	class4_graph_OnPaint(Object sender, PaintEventArgs e)
>>	draw dividing line on class4 graph
>> draw the line on class 4
>> draw point
>> classify the points of 2 class
```

# Discriminate line algorithm



```cs
//classify the points of 2 class
        private void classify_2class()
        {
            //init result value
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    result_2class[i, j] = 0;
            //calulate of normal vector of dividing line
            float nx = (class2_MouseInitialPosition.Y - class2_MouseLastPosition.Y) / yScale;
            float ny = (class2_MouseLastPosition.X - class2_MouseInitialPosition.X) / xScale;
            //transform coordinates about normal vector and first point of line
            float n_sqrt = (float)Math.Sqrt((double)(nx * nx + ny * ny));
            nx = nx / n_sqrt;
            ny = - ny / n_sqrt;
            float line_ptx = (class2_MouseInitialPosition.X - origin.X) / xScale;
            float line_pty = (origin.Y - class2_MouseInitialPosition.Y) / yScale;
            //display region number
            display_region_2class(nx, ny);
            //classify
            float dot_product;
            float dx, dy;
            int total_count = 0;
            //classify class 1 points
            for (int i = 0; i < class21_points_count; i++)
            {
                dx = class21_points[i].X - line_ptx;
                dy = class21_points[i].Y - line_pty;
                dot_product = dx * nx + dy * ny;
                if (dot_product > 0.0f)
                    result_2class[0, 0]++;
                else
                    result_2class[0, 1]++;
                total_count++;
            }
            //classify class 2 points
            for (int i = 0; i < class22_points_count; i++)
            {
                dx = class22_points[i].X - line_ptx;
                dy = class22_points[i].Y - line_pty;
                dot_product = dx * nx + dy * ny;
                if (dot_product > 0.0f)
                    result_2class[1, 0]++;
                else
                    result_2class[1, 1]++;
                total_count++;
            }
            //display result values;
            label16.Text = result_2class[0, 0].ToString();
            label19.Text = result_2class[0, 1].ToString();
            label17.Text = result_2class[1, 0].ToString();
            label20.Text = result_2class[1, 1].ToString();
            //claculate accuracy
            int accuracy_class2 = 100 * (result_2class[0, 0] + result_2class[1, 1]) / total_count;
            label8.Text = accuracy_class2.ToString();
            check_test_end();
        }
```

```cs
//classify the points of 4 class
        private void classify_4class()
        {
            //init result value
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result_4class[i, j] = 0;
            //calulate of normal vector of dividing line
            float line1_nx = -(class4_MouseLastPosition[0].Y - class4_MouseInitialPosition[0].Y) / yScale;
            float line1_ny = (class4_MouseLastPosition[0].X - class4_MouseInitialPosition[0].X) / xScale;
            float line2_nx = -(class4_MouseLastPosition[1].Y - class4_MouseInitialPosition[1].Y) / yScale;
            float line2_ny = (class4_MouseLastPosition[1].X - class4_MouseInitialPosition[1].X) / xScale;
            //transform coordinates about normal vector and first point of line
            float n1_sqrt = (float)Math.Sqrt((double)(line1_nx * line1_nx + line1_ny * line1_ny));
            float n2_sqrt = (float)Math.Sqrt((double)(line2_nx * line2_nx + line2_ny * line2_ny));
            line1_nx = line1_nx / n1_sqrt;
            line1_ny = -line1_ny / n1_sqrt;
            line2_nx = line2_nx / n2_sqrt;
            line2_ny = -line2_ny / n2_sqrt;
            float line1_ptx = (class4_MouseInitialPosition[0].X - origin.X) / xScale;
            float line1_pty = (origin.Y - class4_MouseInitialPosition[0].Y) / yScale;
            float line2_ptx = (class4_MouseInitialPosition[1].X - origin.X) / xScale;
            float line2_pty = (origin.Y - class4_MouseInitialPosition[1].Y) / yScale;
            //display region number
            display_region_4class(line1_nx, line1_ny, line2_nx, line2_ny);
            //classify
            float dot_product1, dot_product2;
            int total_count = 0;
            //classify class 1 points
            for (int i = 0; i < class41_points_count; i++)
            {
                dot_product1 = (class41_points[i].X - line1_ptx) * line1_nx + (class41_points[i].Y - line1_pty) * line1_ny;
                dot_product2 = (class41_points[i].X - line2_ptx) * line2_nx + (class41_points[i].Y - line2_pty) * line2_ny;
                if (dot_product1 > 0.0f) {
                    if (dot_product2 > 0.0f)
                        result_4class[0, 0]++;
                    else
                        result_4class[0, 1]++;
                }
                else
                {
                    if (dot_product2 > 0.0f)
                        result_4class[0, 2]++;
                    else
                        result_4class[0, 3]++;
                }
                total_count++;
            }
            //classify class 2 points
            for (int i = 0; i < class42_points_count; i++)
            {
                dot_product1 = (class42_points[i].X - line1_ptx) * line1_nx + (class42_points[i].Y - line1_pty) * line1_ny;
                dot_product2 = (class42_points[i].X - line2_ptx) * line2_nx + (class42_points[i].Y - line2_pty) * line2_ny;
                if (dot_product1 > 0)
                {
                    if (dot_product2 > 0.0f)
                        result_4class[1, 0]++;
                    else
                        result_4class[1, 1]++;
                }
                else
                {
                    if (dot_product2 > 0.0f)
                        result_4class[1, 2]++;
                    else
                        result_4class[1, 3]++;
                }
                total_count++;
            }
            //classify class 3 points
            for (int i = 0; i < class43_points_count; i++)
            {
                dot_product1 = (class43_points[i].X - line1_ptx) * line1_nx + (class43_points[i].Y - line1_pty) * line1_ny;
                dot_product2 = (class43_points[i].X - line2_ptx) * line2_nx + (class43_points[i].Y - line2_pty) * line2_ny;
                if (dot_product1 > 0)
                {
                    if (dot_product2 > 0.0f)
                        result_4class[2, 0]++;
                    else
                        result_4class[2, 1]++;
                }
                else
                {
                    if (dot_product2 > 0.0f)
                        result_4class[2, 2]++;
                    else
                        result_4class[2, 3]++;
                }
                total_count++;
            }
            //classify class 2 points
            for (int i = 0; i < class44_points_count; i++)
            {
                dot_product1 = (class44_points[i].X - line1_ptx) * line1_nx + (class44_points[i].Y - line1_pty) * line1_ny;
                dot_product2 = (class44_points[i].X - line2_ptx) * line2_nx + (class44_points[i].Y - line2_pty) * line2_ny;
                if (dot_product1 > 0.0f)
                {
                    if (dot_product2 > 0.0f)
                        result_4class[3, 0]++;
                    else
                        result_4class[3, 1]++;
                }
                else
                {
                    if (dot_product2 > 0.0f)
                        result_4class[3, 2]++;
                    else
                        result_4class[3, 3]++;
                }
                total_count++;
            }
            //display result values;
            label29.Text = result_4class[0, 0].ToString();
            label30.Text = result_4class[1, 0].ToString();
            label31.Text = result_4class[2, 0].ToString();
            label32.Text = result_4class[3, 0].ToString();
            label34.Text = result_4class[0, 1].ToString();
            label35.Text = result_4class[1, 1].ToString();
            label36.Text = result_4class[2, 1].ToString();
            label37.Text = result_4class[3, 1].ToString();
            label39.Text = result_4class[0, 2].ToString();
            label40.Text = result_4class[1, 2].ToString();
            label41.Text = result_4class[2, 2].ToString();
            label42.Text = result_4class[3, 2].ToString();
            label44.Text = result_4class[0, 3].ToString();
            label45.Text = result_4class[1, 3].ToString();
            label46.Text = result_4class[2, 3].ToString();
            label47.Text = result_4class[3, 3].ToString();
            //claculate accuracy
            int accuracy_class4 = 100 * (result_4class[0, 0] + result_4class[1, 1] + result_4class[2, 2] + result_4class[3, 3]) / total_count;
            label9.Text = accuracy_class4.ToString();
            check_test_end();
        }
```
### check_test_end
```cs
>> check_test_end()
>> check if test is finished
```

### submit_OnClick
```cs
>> save result in text file
>> check if it gets the result's score 
>> save result
>> text is added only once to the file
>> Create a file to write to.
>> Write result data to CSV file
>> write user name
>> write elapsed time
>> write score for 2-class
>> write score for 4-class
  
  //this will take you back to the main page
            this.Hide();
            var myForm = new main();
            myForm.Show();
```
### display_region_2class
```cs
>> display region number for 2-class
```
### display_region_4class
```cs
>> display region number for 4-class
``

### UI Button Control
* The buttons used for this project were the defult buttons that were provided with WinForm via Visual Studio 2017.
* The Icons were created by Icon8 
* Button Click to another form was achived by 

* This will ***hide*** the current form and ***show*** the desired form 

```cs
    private void button_click(object sender, EventArgs e)
        {		
            this.Hide();
            var myForm = new main();
            myForm.Show();
        }
```
* This will ***exite*** the current form 

```cs
    private void button_click(object sender, EventArgs e)
        {		
          //this will exit application
            Application.Exit();
        }
```
###UI Charts 

```cs
NOTE: The chars were Created with the picture box tool from Winform Liburary 
```
* This will get the points from the chosen file
* Once the user have made their selection, this code will set the chart 

```cs
//form1.cs
//get file name for inputting 2 class data
        private void get_2classes_data()
        {
            OpenFileDialog openFileDg = new OpenFileDialog();

            openFileDg.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\Res";
            openFileDg.Filter = "CSV (*.csv)|*.csv";
            openFileDg.FilterIndex = 2;
            openFileDg.RestoreDirectory = true;
            openFileDg.Multiselect = false;

            if (openFileDg.ShowDialog() == DialogResult.OK)
            {
                Globals.input_2class_filename = openFileDg.FileName;
            }
        }
        //get file name for inputting 4 class data
        private void get_4classes_data()
        {
            OpenFileDialog openFileDg = new OpenFileDialog();

            openFileDg.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\Res";
            openFileDg.Filter = "CSV (*.csv)|*.csv";
            openFileDg.FilterIndex = 2;
            openFileDg.RestoreDirectory = true;
            openFileDg.Multiselect = false;

            if (openFileDg.ShowDialog() == DialogResult.OK)
            {
                Globals.input_4class_filename = openFileDg.FileName;
            }
        }
```

```cs
//forms2.cs is where actual population of the chart will take place 
//this is a preview of the algorithm refur to file for additinal info

//input points data for 2 and 4 class
        private void input_points();
//draw coordinate axis on 2 class graph
        private void draw_class2_axis(PaintEventArgs g);
//draw coordinate axis on 4 class graph
        private void draw_class4_axis(PaintEventArgs g);
//draw points for 2 class 
        private void draw_2class_points(PaintEventArgs g);
//draw points for 4 class 
        private void draw_4class_points(PaintEventArgs g);


```



# Confusion Matrix Algorithm 

![alt text](https://github.com/pfdinc/LDA-QDA/blob/master/photo/Screen%20Shot%202017-09-25%20at%2011.31.13%20PM.png)









