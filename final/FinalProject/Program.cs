using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Type 1 Diabetic Assistant!");
        Thread.Sleep(5000);
        Console.WriteLine("This tool helps you check your blood sugar, get advice on what to do, and learn how to handle emergencies.");
        Thread.Sleep(10000);
        Console.WriteLine("Stay safe, stay strong, and take control of your health!");
        Thread.Sleep(5000);

        Program p = new Program();
        p.DisplayChoice();

        Console.Write("\n> ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            p.DisplayBloodSugarChoice();

            Console.Write("\n> ");
            string BloodSugar = Console.ReadLine();
            Console.WriteLine();

            if (BloodSugar == "1")
            {
                Console.WriteLine("BloodSugar 1");
            }
            else if (BloodSugar == "2")
            {
                Console.WriteLine("BloodSugar 2");
            }
            else if (BloodSugar == "3")
            {
                Console.WriteLine("BloodSugar 3");
            }
            else if (BloodSugar == "4")
            {
                Console.WriteLine("BloodSugar 4");
            }
            else if (BloodSugar == "5")
            {
                Console.WriteLine("BloodSugar 5");
            }
        }
        else if (choice == "2")
        {
            p.DisplayInfoChoice();

            Console.Write("\n> ");
            string InfoChoice = Console.ReadLine();
            Console.WriteLine();

            if (InfoChoice == "1")
            {
                EmergencyLow low = new EmergencyLow("First off, you are not alone. A Type 1 Diabetes diagnosis can feel overwhelming at first, but many people live full, healthy, and active lives with it. The key is understanding how T1D works and learning how to manage it.", 
                "At its core, Type 1 Diabetes is an autoimmune condition.This means the body's immune system mistakenly attacks the insulin-producing cells in the pancreas. Because of this, the body can no longer make insulin, which is essential for turning food into energy. Without insulin, sugar (glucose) stays in the bloodstream instead of getting into cells where it’s needed. This leads to high blood sugar levels, which, if not managed, can cause both short-term and long-term health issues. The good news? Insulin therapy and careful blood sugar management allow people with Type 1 Diabetes to live normal, healthy lives.It takes daily attention, but over time, managing T1D becomes second nature. Most importantly, you are not alone in this journey—there is a whole community, along with doctors, educators, and other families, who can support you every step of the way.",
                "Learning to take control of your health and well-being is no small task, and the fact that you've taken this step speaks volumes about your strength and determination. Managing Type 1 Diabetes—or supporting a loved one who has it—is a journey, not a destination.You will keep learning, growing, and adapting, and that’s okay.The most important thing is that you now have the knowledge and tools to take charge with confidence. Thank you for investing in yourself and your future.Keep moving forward with courage, confidence, and self - compassion.You’ve got this! 💙", 
                "Recognizing a Low Blood Sugar Emergency: A low blood sugar(hypoglycemia) emergency happens when blood glucose levels drop below 70 mg / dL(or as directed by a doctor).This can happen quickly, especially after exercise, too much insulin, or missing a meal. Common symptoms include: Shakiness or dizziness, Sweating, Confusion or difficulty concentrating, Irritability or sudden mood changes, Weakness or fatigue, Hunger, Blurry vision, and Fast heartbeat. If blood sugar drops too low and is not treated, it can lead to unconsciousness or seizures.This is why fast action is necessary.",
                "Step 1: Follow the 15-15 Rule! The best way to treat a low blood sugar emergency (if the person is awake and able to eat) is to use the 15-15 rule: 1️⃣ Eat or drink 15 grams of fast-acting carbohydrates 2️⃣ Wait 15 minutes and check blood sugar again 3️⃣ If blood sugar is still below 70 mg/dL, repeat the process. Once blood sugar returns to normal, eat a small protein-based snack (like peanut butter or cheese with crackers) to prevent another drop.",
                "Step 2: Best Fast-Acting Carbohydrates for Emergency Lows! Not all foods work the same way. In an emergency low, you need fast-acting, simple carbohydrates (without fat or protein) because they absorb quickly into the bloodstream. ✅ Good options (15g carbs each): 4 oz (½ cup) juice (apple, orange, grape), 4 oz (½ cup) regular soda (NOT diet), Glucose tablets (3-4 tablets), Glucose gel (one tube), 1 tablespoon honey or sugar, 6-7 small candies (like Smarties or Skittles), 5-6 gummy bears. Tip: Always carry at least one of these items with you at all times!",
                "Step 3: What to Do If the Low Doesn't Improve! If, after two rounds of the 15-15 rule, blood sugar does not rise above 70 mg/dL, or the person is: ⚠ Still feeling symptoms, ⚠ Too confused to eat, ⚠ Becoming unresponsive: ➡ Call 911 or use glucagon immediately. (Glucagon is an emergency injection that raises blood sugar quickly and is used when the person cannot eat or drink.)",
                "Step 4: Preventing Future Lows! Once the emergency is over, take steps to avoid another low: ✔ Eat a balanced meal or snack with protein + complex carbs (like a turkey sandwich or yogurt with fruit), ✔ Monitor blood sugar regularly, especially before and after exercise, ✔ Adjust insulin doses if lows are happening frequently (talk to a doctor).💡 Pro Tip: Always carry fast-acting carbs (like juice boxes or glucose tablets) in your bag, car, or pocket so you're prepared for any situation.",
                "Lows can happen, but knowing how to treat them quickly with the right foods can prevent a serious emergency. With time, you’ll learn how your body reacts to different situations, helping you stay in control.",
                "Glucagon is a lifesaving hormone that raises blood sugar when it drops dangerously low. It works by telling the liver to release stored glucose into the bloodstream, which helps bring blood sugar back to a safe level. While fast-acting carbohydrates like juice or glucose tablets are the first choice for treating mild to moderate lows, glucagon is necessary when the person is unconscious, having a seizure, or too confused to eat or drink safely. In these cases, do not attempt to give food or liquids, as this could cause choking. Instead, administer glucagon immediately. There are three main types available: the traditional glucagon injection kit, which requires mixing a powdered glucagon with a liquid before injecting it into the thigh or arm; the Gvoke HypoPen, a pre-mixed auto-injector that works like an EpiPen and requires no preparation; and Baqsimi, a nasal powder that is sprayed into the nose and absorbs through the membranes without requiring inhalation. Once glucagon is given, blood sugar should begin to rise within 5 to 15 minutes, but the person may feel nauseous, vomit, or experience grogginess as they recover. As soon as they are awake and able to swallow, they should eat a small snack containing both carbohydrates and protein to prevent another drop in blood sugar. Even if they recover quickly, it is important to follow up with a doctor or seek medical attention, especially if they were unconscious or had a seizure. Because severe lows can happen unexpectedly, it is essential to carry glucagon at all times and ensure that family members, friends, teachers, or caregivers know how to use it. Additionally, check expiration dates regularly and replace expired glucagon to ensure it will work when needed. While glucagon is a crucial emergency treatment, it is always best to prevent severe lows when possible by monitoring blood sugar levels, recognizing early symptoms, and treating mild lows with fast-acting carbohydrates before they become more serious. Understanding when and how to use glucagon provides an extra layer of safety and ensures that severe low blood sugar emergencies can be handled quickly and effectively.",
                "A hospital visit may be necessary for severe low or high blood sugar emergencies that cannot be managed at home. If a person experiences a severe low and becomes unconscious, has a seizure, or does not respond to glucagon, they should be taken to the hospital immediately. Likewise, if a high blood sugar emergency occurs, such as diabetic ketoacidosis (DKA), which is marked by extreme thirst, vomiting, confusion, rapid breathing, and a fruity odor on the breath, urgent medical care is required. Upon arrival, medical staff will check blood sugar levels, ketones, and electrolyte balance to assess the severity of the situation. For severe lows, they may administer an intravenous (IV) glucose solution to quickly raise blood sugar, and for DKA, they will provide fluids, insulin, and electrolytes to stabilize the body. A hospital stay can last anywhere from a few hours for mild cases to several days if complications arise. After stabilization, doctors may review insulin dosages, dietary habits, and potential causes of the emergency to help prevent future occurrences. It is essential to seek medical help if a low blood sugar episode cannot be corrected with food or glucagon, if persistent vomiting prevents fluids and food intake, or if blood sugar remains dangerously high despite taking insulin. Understanding when to go to the hospital ensures that life-threatening complications are treated quickly while also helping prevent future emergencies through proper diabetes management.");
                
                Console.WriteLine(low.GetIntro());
                Thread.Sleep(10000);
                Console.WriteLine("");
                Console.WriteLine(low.GetInfo());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoIntro());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoStep1());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoStep2());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoStep3());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoStep4());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetLowFoodInfoFinal());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetHospital());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetGlucagon());
                Thread.Sleep(15000);
                Console.WriteLine("");
                Console.WriteLine(low.GetExit());
            }
            else if (InfoChoice == "2")
            {
                Console.WriteLine("InfoChoice 2");
            }
        }

    }

    public void DisplayChoice()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("\n1. Check Blood Sugar");
        Console.WriteLine("2. Get Emergency Information");
    }

    public void DisplayBloodSugarChoice()
    {
        Console.WriteLine("What is the range of your Blood Sugar?");
        Console.WriteLine("\n1. Below 55  (Extreme Low)");
        Console.WriteLine("2. 55 - 69   (Low)");
        Console.WriteLine("3. 70 - 140  (Normal)");
        Console.WriteLine("4. 141 - 250 (High)");
        Console.WriteLine("5. Above 250 (Extreme High)");
    }

    public void DisplayInfoChoice()
    {
        Console.WriteLine("What would you like to learn about?");
        Console.WriteLine("\n1. Emergency Low – What to do when blood sugar is dangerously low");
        Console.WriteLine("2. Emergency High – How to handle extremely high blood sugar");
    }
}