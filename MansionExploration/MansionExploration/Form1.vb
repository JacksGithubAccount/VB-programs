Public Class FormMain
    Dim entranceStrings(10) As String
    Dim inventory(5) As item
    Dim items(20) As item
    Dim choice As Integer
    Dim pointInStory As String
    Dim inventorySelect As Integer
    Dim niftyFound As Boolean
    Dim porcToilFound As Boolean
    Dim ramenFound As Boolean
    Dim catFound As Boolean
    Dim jewelboxFound As Boolean
    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pointInStory = "entrance"
        choice = 0
        niftyFound = False
        entranceStrings(0) = "You are a private investigator here to find out about the mysterious"
        entranceStrings(1) = "mysteries that has been happening in this out of the way town."
        clearText()
        storyTell(pointInStory, choice)
        items(0) = New item("Detective Badge", "Your detective badge. Your only proof of you being a detective.", "private_investigators_badge")
        items(1) = New item("Nifty Shades of Beige", "A terrible rip off of a bad fanfic.", "nifty_shades_of_beige")
        items(2) = New item("Porcelain Toilent", "Super shiny toilet. Try not to drop it.", "porcelain_toilet")
        items(3) = New item("Beef Ramen", "Your dinner tonight.", "beef_ramen")
        items(4) = New item("Jewelbox", "Not sure what's inside, but it's got to have a fortune in it!", "jewelbox")
        items(5) = New item("Black Cat", "Found this guy in the living room. Guess it seemed a little lonely.", "black_cat")
        inventory(0) = items(0)
    End Sub
    Private Sub storyTell(location As String, number As Integer)
        ' entrance
        If (location = "entrance" And number = "1") Then
            pointInStory = "foyer"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.foyer
            storyTell("foyer", 0)
        ElseIf (location = "entrance" And number = "2") Then
            clearText()
            Label1.Text = entranceStrings(0)
            Label2.Text = entranceStrings(1)
        ElseIf (location = "entrance" And jewelboxFound = True) Then
            clearText()
            pointInStory = "game over"
            Label1.Text = "You finally made it out of the mansion without encountering a single soul! Now hopefully" + Environment.NewLine +
                          "to a better life! But there is a nagging thought in the back of your head. Something that" + Environment.NewLine +
                          "says this was too easy. Maybe it was related to the mystery behind this mansion, but you" + Environment.NewLine +
                          "guess we'll neverknow. Maybe you should open this box. You open the box. There is no jewel." + Environment.NewLine +
                          " Only a note. Written on it is 'Stealing is wrong. -Signed 'your boss''. Nuts. You did it" + Environment.NewLine +
                          "this time. Your boss will never let you live this one down."
        ElseIf (location = "entrance") Then
            clearText()
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.front_mansion2
            Label1.Text = "You are standing in front of a rundown mansion that looks kind of abandoned."
            Label2.Text = "What do you do?"
            Label3.Text = "[1] - Go inside"
            Label4.Text = "[2] - Ask 'Why am I here?' to yourself"
        End If
        ' foyer
        If (location = "foyer" And number = 1) Then
            clearText()
            pointInStory = "foyer2"
            Label1.Text = "Before you can go forward, you notice staircases on both sides of the center door. They" + Environment.NewLine +
                          "probably lead to the same place. What do you do?"
            Label3.Text = "[1] - Go through the center room"
            Label4.Text = "[2] - Go up the stairs"
            Label5.Text = "[3] - Back to other options"
        ElseIf (location = "foyer" And number = 2) Then
            pointInStory = "living room"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.living_room
            storyTell("living room", 0)
        ElseIf (location = "foyer" And number = 3) Then
            pointInStory = "stairs"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.stairs
            storyTell("stairs", 0)
        ElseIf (location = "foyer" And number = 4) Then
            pointInStory = "entrance"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.front_mansion2
            storyTell("entrance", 0)
        ElseIf (location = "foyer") Then
            clearText()
            Label1.Text = "Now standing in a grand foyer of this mansion, you stare in awe at the amazement this "
            Label2.Text = "place brings. What do you do?"
            Label3.Text = "[1] - Continue forward"
            Label4.Text = "[2] - Go to the left room"
            Label5.Text = "[3] - Go to the Right room"
            Label6.Text = "[4] - Return to the entrance"
        End If
        'foyer 2
        If (location = "foyer2" And number = 1) Then
            pointInStory = "strange"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.strange
            storyTell("strange", 0)
        ElseIf (location = "foyer2" And number = 2) Then
            pointInStory = "second floor"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.second_floor
            storyTell("second floor", 0)
        ElseIf (location = "foyer2" And number = 3) Then
            pointInStory = "foyer"
            storyTell("foyer", 0)
        ElseIf (location = "foyer2") Then
            pointInStory = "foyer"
            storyTell("foyer", 1)
        End If
        'living room
        If (location = "living room" And number = 1) Then
            pointInStory = "library"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.library
            storyTell("library", 0)
        ElseIf (location = "living room" And number = 2) Then
            pointInStory = "foyer"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.foyer
            storyTell("foyer", 0)
        ElseIf (location = "living room") Then
            clearText()
            Label1.Text = "Finding yourself in the living room, you feel like this place is very calm and "
            Label2.Text = "relaxing. What do you do?"
            Label3.Text = "[1] - Go right"
            Label4.Text = "[2] - Return to the foyer"
        End If
        'library
        If (location = "library" And number = 3) Then
            clearText()
            Label1.Text = "You feel as if there is no real need to go any farther in this library."
        ElseIf (location = "library" And number = 4) Then
            pointInStory = "living room"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.living_room
            storyTell("living room", 0)
        ElseIf (location = "library") Then
            clearText()
            Label1.Text = "There are books lined up against the bookshelves which are against the walls. You feel"
            Label2.Text = "very compelled to leave this area for you have a fear of books. The more you stare at" + Environment.NewLine +
                          "the books, the more you feel like these books are going to suck your soul. You want to" + Environment.NewLine +
                          "leave. Maybe not now, but soon. What do you do?"
            Label5.Text = "[1] - Continue foward"
            Label6.Text = "[2] - Leave and return to the living room"
        End If
        ' stairs
        If (location = "stairs" And number = 2) Then
            pointInStory = "bathroom"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.Bathroom
            storyTell("bathroom", 0)
        ElseIf (location = "stairs" And number = 3) Then
            pointInStory = "second floor"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.second_floor
            storyTell("second floor", 0)
        ElseIf (location = "stairs" And number = 4) Then
            pointInStory = "foyer"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.foyer
            storyTell("foyer", 0)
        ElseIf (location = "stairs") Then
            clearText()
            Label1.Text = "This is some Escherian bull. No way in the world are you going to walk up those stairs."
            Label2.Text = "Maybe unless you were somehow manipulated by an outside force that commands you to" + Environment.NewLine +
                          "walk up those stairs to reach the second floor. What do you do?"
            Label4.Text = "[1] - Enter the closest door to your left"
            Label5.Text = "[2] - Walk up the stairs"
            Label6.Text = "[3] - Return to the foyer"
        End If
        ' bathroom
        If (location = "bathroom" And number = 1) Then
            clearText()
            Label1.Text = "You go to wash your hands for no apparent reason. Your hands are now clean. For the first" + Environment.NewLine +
                          "time since you visited the precinct. Your sink in your apartment is broken and doesn't" + Environment.NewLine +
                          "work."
        ElseIf (location = "bathroom" And number = 2) Then
            pointInStory = "stairs"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.stairs
            storyTell("stairs", 0)
        ElseIf (location = "bathroom") Then
            clearText()
            Label1.Text = "Whoa, this is not escherian at all. It's... a normal bathroom. Well, it's a bathroom"
            Label2.Text = "that's more high quality than the one you have at your apartment. What do you do?"
            Label3.Text = "[1] - Wash your hands"
            Label4.Text = "[2] - Return to those stairs"
        End If
        ' second floor
        If (location = "second floor" And number = 1) Then
            pointInStory = "dining room"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.dining_room
            storyTell("dining room", 0)
        ElseIf (location = "second floor" And number = 2) Then
            pointInStory = "master bedroom"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.master_bedroom
            storyTell("master bedroom", 0)
        ElseIf (location = "second floor" And number = 3) Then
            pointInStory = "foyer"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.foyer
            storyTell("foyer", 0)
        ElseIf (location = "second floor" And number = 4) Then
            pointInStory = "stairs"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.stairs
            storyTell("stairs", 0)
        ElseIf (location = "second floor") Then
            clearText()
            Label1.Text = "This is a really grand place only topped by the overtopness of the foyer. Seeing all" + Environment.NewLine +
                          "the high class stuff really makes you wish you didn't live in filth. What do you do?"
            Label3.Text = "[1] - Dining room(The room with the giant plaque on the door that says 'dining room')"
            Label4.Text = "[2] - Master bedroom to the left(there's a sign. Or at least that's what it looks like)"
            Label5.Text = "[3] - Return to the foyer"
            Label6.Text = "[4] - Go to the 'stairs'"
        End If
        ' dining room
        If (location = "dining room" And number = 2) Then
            clearText()
            Label1.Text = "You think about going to the kitchen and how terrible of an idea that would be. There's" + Environment.NewLine +
                          "no need to torture yourself over the food they must have over yours. Just because your" + Environment.NewLine +
                          "daily grub consists of grilled cheese sandwiches and cheese quesadilla, doesn't mean" + Environment.NewLine +
                          "that you should feel bad. In fact, you feel great about how you eat. Not really. I mean" + Environment.NewLine +
                          "eating ramen everyday isn't something to brag about. Now you just feel sad."
        ElseIf (location = "dining room" And number = 3) Then
            pointInStory = "second floor"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.second_floor
            storyTell("second floor", 0)
        ElseIf (location = "dining room") Then
            clearText()
            Label1.Text = "The aroma wafting around this hall is really nice. It's... elegant and very nice."
            Label2.Text = "All the expensive stuff around here definitely shows the class these people have." + Environment.NewLine +
                          "What do you do?"
            Label4.Text = "[1] - Enter the kitchen"
            Label5.Text = "[2] - Return to the second floor lobby"
        End If
        ' Master bedroom
        If (location = "master bedroom" And number = 2) Then
            clearText()
            Label1.Text = "You wish you could nap, but then your supervisor would hear all about it and that" + Environment.NewLine +
                          "won't end nicely. Then again, not much does for you. Maybe it wouldn't hurt just " + Environment.NewLine +
                          "a bit, at least for a while. A strange image of you being whipped by your " + Environment.NewLine +
                          "supervisor enters your head. No way. You think sleeping on the job is a bad idea" + Environment.NewLine +
                          "and shouldn't ever happen."
        ElseIf (location = "master bedroom" And number = 3) Then
            pointInStory = "second floor"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.second_floor
            storyTell("second floor", 0)
        ElseIf (location = "master bedroom") Then
            clearText()
            Label1.Text = "Whoa, talk about a fancy party for elegant people. This is the bedroom of bedrooms." + Environment.NewLine +
                          "This... really takes the cake. Now you kinda wished you picked something better for" + Environment.NewLine +
                          "a career than a poor private investigator. What do you do?"
            Label4.Text = "[1] - Take a nap"
            Label5.Text = "[2] - Return back to second floor lobby"
        ElseIf (location = "game over") Then
            clearText()
            Label1.Text = "Congrats! You beat Mansion Exploration! Now you can try it again on New Game Plus!" + Environment.NewLine +
                          "(There is no new game plus, the creator just wants more attention than he deserves)'"
        End If
        ' strange
        If (location = "strange" And number = 2) Then
            pointInStory = "foyer"
            GroupBox1.BackgroundImage = MansionExploration.My.Resources.foyer
            storyTell("foyer", 0)
        ElseIf (location = "strange") Then
            clearText()
            Label1.Text = "What the... What is this room? It's really strange and bizarre. You have a really " + Environment.NewLine +
                          "strong feeling to leave this room. What... what is that in the middle? You really" + Environment.NewLine +
                          "don't want to find out."
            Label4.Text = "[1] - Return to foyer"
        End If
    End Sub
    Private Sub clearText()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label3.Enabled = True
        Label4.Enabled = True
        Label5.Enabled = True
        Label6.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        If (Label3.Text <> "") Then
            Label3.Enabled = False
            Label4.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True
            choice = 1
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        If (Label4.Text <> "") Then
            Label4.Enabled = False
            Label3.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True
            choice = 2
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        If (Label5.Text <> "") Then
            Label5.Enabled = False
            Label4.Enabled = True
            Label3.Enabled = True
            Label6.Enabled = True
            choice = 3
        End If
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        If (Label6.Text <> "") Then
            Label6.Enabled = False
            Label4.Enabled = True
            Label5.Enabled = True
            Label3.Enabled = True
            choice = 4
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNext.Click
        storyTell(pointInStory, choice)
        choice = 0
        inventorySelect = 0
    End Sub

    Private Sub ButtonInspect_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInspect.Click
        choice = 0
        If (inventorySelect = 0) Then
            If (pointInStory = "entrance") Then
                clearText()
                Label1.Text = "This is a pretty spooky mansion. Too bad you're stuck with this Investigation."
                Label2.Text = "May as well go inside and crack this case." + Environment.NewLine + "As far as you can tell, there is nothing 'out of the ordinary' out here."
            ElseIf (pointInStory = "foyer") Then
                clearText()
                Label1.Text = "A well made foyer. Grandeur to the max, and definitely gives the feeling of high class."
                Label2.Text = "Something you'll never have with your budget of being a private investigator."
            ElseIf (pointInStory = "living room") Then
                clearText()
                Label1.Text = "This living room even has a fireplace! Nice, warm, roomy, and cozy! Now only if your"
                Label2.Text = "room was like this. But allas, that is a luxury you can't afford."
            ElseIf (pointInStory = "library") Then
                clearText()
                Label1.Text = "Books. Books as far as the eye can see. Reminds you of the days of you studying for the" + Environment.NewLine +
                              "bar exams. Too bad you failed at that test. Failed all 26 tests you took. Now that was" + Environment.NewLine +
                              "a bad time. Anyways skimming over the titles of the books, nothing seems to stand out or" + Environment.NewLine +
                              "catch your interests. They all seem like hobby books. One's entitled 'Nifty Shades of" + Environment.NewLine +
                              "Beige. Huh. That sounds like a terrible rip off of a terrible fanfic. But what do I know."
            ElseIf (pointInStory = "stairs") Then
                clearText()
                Label1.Text = "You still can't get your head around how they do that kind of stuff. After all, you didn't" + Environment.NewLine +
                              "wrap your head around this in college, so why would you get this kind of stuff now?"
            ElseIf (pointInStory = "bathroom") Then
                clearText()
                Label1.Text = "After a careful looking around, you manage to find out that one of the toilets there is " + Environment.NewLine +
                              "made entirely out of porcelain. You're not exactly sure why, but it's there."
            ElseIf (pointInStory = "second floor") Then
                clearText()
                Label1.Text = "Not only is this place high class, it's also big! One could probably get lost here if " + Environment.NewLine +
                              "they didn't know what they were doing."
            ElseIf (pointInStory = "dining room") Then
                clearText()
                Label1.Text = "Well, there's not much here. There's no food on the table. You guess that's a good thing." + Environment.NewLine +
                              "If there was food on the table, you'd probably be eating them right now too. Wait, what's" + Environment.NewLine +
                              "that in the corner? It's a packet of instant noodles! Ramen, beef flavor. One of the two " + Environment.NewLine +
                              "flavors that your always have your ramen in."
            ElseIf (pointInStory = "master bedroom") Then
                clearText()
                Label1.Text = "All this gaudy house is about you suddenly want. But many things in your life is preventing" + Environment.NewLine +
                              "that. Like your job, your boss, your morales, your little pride, your consious, and even" + Environment.NewLine +
                              "your family. Despite all that, you feel the need to take something from the room, although" + Environment.NewLine +
                              "you're not entirely sure what."
            ElseIf (pointInStory = "strange") Then
                clearText()
                Label1.Text = "Are those... are those... spiders? Oh man, that reminds you of a silly game you once bought" + Environment.NewLine +
                             "called Araxnid. It was a video game where once you load the game to play, it would say " + Environment.NewLine +
                             "'Araxnid' in a really deep voice, then a bunch of spider came out and ate you. Needless to" + Environment.NewLine +
                             "say, it was painful."
            End If
        ElseIf (inventorySelect = 1) Then
            clearText()
            Label1.Text = inventory(0).myName
            Label2.Text = inventory(0).myDescription
        ElseIf (inventorySelect = 2) Then
            clearText()
            Label1.Text = inventory(1).myName
            Label2.Text = inventory(1).myDescription
        ElseIf (inventorySelect = 3) Then
            clearText()
            Label1.Text = inventory(2).myName
            Label2.Text = inventory(2).myDescription
        ElseIf (inventorySelect = 4) Then
            clearText()
            Label1.Text = inventory(3).myName
            Label2.Text = inventory(3).myDescription
        ElseIf (inventorySelect = 5) Then
            clearText()
            Label1.Text = inventory(4).myName
            Label2.Text = inventory(4).myDescription
        ElseIf (inventorySelect = 6) Then
            clearText()
            Label1.Text = inventory(5).myName
            Label2.Text = inventory(5).myDescription
        End If
        inventorySelect = 0
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        inventorySelect = 1

    End Sub

    Private Sub ButtonTake_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTake.Click
        clearText()
        If (pointInStory = "library" and niftyFound = True) Then
            Label1.Text = "You don't find anything else useful here. All this book browsing feels like it took 20 years" + Environment.NewLine +
                          "off of your life span."

        ElseIf (pointInStory = "library") Then
            inventory(1) = items(1)
            niftyFound = True
            GroupBoxInv2.BackgroundImage = MansionExploration.My.Resources.nifty_shades_of_beige
            Label1.Text = "You relectantly take the book entitled 'Nifty Shades of Beige. Who knows? It may come in" + Environment.NewLine +
                          "handy one day."
        ElseIf (pointInStory = "bathroom" And porcToilFound = True) Then
            Label1.Text = "You took a toilet! Do you think you can carry anything else out of here?!"
        ElseIf (pointInStory = "bathroom") Then
            inventory(2) = items(2)
            porcToilFound = True
            GroupBoxInv3.BackgroundImage = MansionExploration.My.Resources.porcelain_toilet
            Label1.Text = "Guess you'll be taking this porcelain toilet. Not like anyone's going to notice."
        ElseIf (pointInStory = "dining room" And ramenFound = True) Then
            Label1.Text = "Nothing else here? not even another pack? Aww, oh well, you guess just one pack is fine."
        ElseIf (pointInStory = "dining room") Then
            inventory(3) = items(3)
            ramenFound = True
            GroupBoxInv4.BackgroundImage = MansionExploration.My.Resources.beef_ramen
            Label1.Text = "Hey, you think you just found your dinner tonight! No more sleeping hunger for this guy!"
        ElseIf (pointInStory = "master bedroom" And jewelboxFound = True) Then
            Label1.Text = "What are you still doing here? Hurry to the entrance before someone finds you!"
        ElseIf (pointInStory = "master bedroom") Then
            inventory(4) = items(4)
            jewelboxFound = True
            GroupBoxInv5.BackgroundImage = MansionExploration.My.Resources.jewelbox
            Label1.Text = "Is that... Is that a jewelbox over there? No one can possibly notice a small box missing!" + Environment.NewLine +
                          "I mean it's just a small box, just take it pocket it and walk out of the mansion like you" + Environment.NewLine +
                          "weren't even assigned to be here. Just walk back to the entrance. It'll be alright."
        ElseIf (pointInStory = "living room" And catFound = True) Then
        ElseIf (pointInStory = "living room") Then
            inventory(5) = items(5)
            catFound = True
            GroupBoxInv6.BackgroundImage = MansionExploration.My.Resources.black_cat
            Label1.Text = "You look around to find nothing suspicious at all. Well except for that black cat. You've" + Environment.NewLine +
                          "pocketed weirder things. May as well pocket that cat."
        Else
            Label1.Text = "There's nothing useful to take here!"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If (niftyFound = True) Then
            inventorySelect = 2
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        If (porcToilFound = True) Then
            inventorySelect = 3
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        If (ramenFound = True) Then
            inventorySelect = 4
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        If (jewelboxFound = True) Then
            inventorySelect = 5
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        If (catFound = True) Then
            inventorySelect = 6
        End If
    End Sub
End Class
