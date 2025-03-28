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
                ExtremeLowBloodSugar extremeLow = new ExtremeLowBloodSugar("The best choices include glucose tablets or glucose gel, which are specifically designed to raise blood sugar rapidly. Other effective options include 4 ounces (½ cup) of juice or regular soda, 1 tablespoon of honey or syrup, or hard candies like Smarties or jelly beans, as long as they are not sugar-free.",
                "After consuming 15 grams of fast-acting carbohydrates, blood sugar should be checked again in 15 minutes, and if it remains low, another dose should be taken. Once blood sugar rises above 70 mg/dL, a balanced snack that includes protein and complex carbohydrates, such as peanut butter with crackers or a small sandwich, can help maintain stable levels and prevent another drop. Acting quickly with the right foods can prevent more severe symptoms and the risk of passing out or needing emergency medical intervention.");

                Console.WriteLine();
                extremeLow.Base();
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeLow.GetFood());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeLow.GetNextSteps());
            }
            else if (BloodSugar == "2")
            {
                Low bloodLow = new Low("If your blood sugar is between 55 and 70 mg/dL, you should eat 15 grams of fast-acting carbohydrates like glucose tablets, juice, or regular soda. Wait 15 minutes, then check your blood sugar again. If it's still below 70 mg/dL, take another 15 grams and repeat the process. Once your blood sugar is back to normal, eat a balanced snack with protein and complex carbs, like crackers with peanut butter or cheese, to keep your levels stable and prevent another drop.",
                "Other good food(s) would be glucose gel, or 4 ounces (½ cup), a tablespoon of honey, maple syrup, or regular sugar, or small amounts of fast-dissolving candies like Smarties or Skittles (not sugar-free).");

                Console.WriteLine();
                bloodLow.Base();
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(bloodLow.GetNextStepsL());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(bloodLow.GetFoodL());
            }
            else if (BloodSugar == "3")
            {
                Normal normal = new Normal("A normal blood sugar level means your body has the right amount of glucose to provide energy without being too high or too low. This is the safest range, where you can think clearly, feel good, and your body functions properly. Keeping your blood sugar in this range as much as possible helps prevent long-term health problems and keeps you feeling your best.");

                Console.WriteLine();
                normal.Base();
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(normal.GetNormal());
            }
            else if (BloodSugar == "4")
            {
                High bloodHigh = new High("If your blood sugar is between 141 and 250 mg/dL, it's higher than normal but not an emergency. Drink water to help flush out excess sugar, take a short walk or light activity if safe, and check if you might have missed a dose of insulin or medication. If your blood sugar stays high or keeps rising, monitor it closely and follow your doctor’s guidance on correction doses or other adjustments.",
                "If your blood sugar is between 141 and 250 mg/dL, you may need insulin to help bring it back to a normal range, depending on your treatment plan. If you use a pump, check for malfunctions or blockages. If you take injections, follow your doctor’s guidelines for a correction dose based on your insulin sensitivity. Always wait at least 2 hours after a correction before taking more to avoid low blood sugar. Stay hydrated, monitor your levels, and use insulin carefully to prevent highs from turning into an emergency.",
                "Water is essential when blood sugar is high because it helps your body remove excess glucose through urination. When blood sugar rises, your kidneys work harder to filter and remove the extra sugar, and drinking plenty of water helps speed up this process, preventing further buildup. Staying hydrated also prevents dehydration, which can happen quickly when blood sugar is elevated. The sooner you lower your blood sugar with water, insulin (if needed), and light activity, the less strain there is on your body, reducing the risk of fatigue, headaches, and further complications like ketone buildup. By drinking enough water, you help your body stabilize blood sugar more efficiently and feel better faster.");

                Console.WriteLine();
                bloodHigh.Base();
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(bloodHigh.GetNextStepsH());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(bloodHigh.GetInsulin());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(bloodHigh.GetWater());
            }
            else if (BloodSugar == "5")
            {
                ExtremeHigh extremeHigh = new ExtremeHigh("Act quickly to prevent it from getting worse. Drink plenty of water to help flush out excess sugar, and check for ketones if possible. If ketones are present or you feel sick, follow your emergency plan and consider seeking medical help. If you take insulin, follow your doctor’s correction guidelines, but wait at least 2 hours before taking more to avoid dropping too fast. Light activity may help, but avoid exercise if ketones are present. Keep monitoring your blood sugar and stay hydrated until it comes down to a safer range.",
                "You may need a correction dose of insulin to bring it back to a safe range. Follow your doctor’s guidelines for insulin adjustments based on your correction factor. If you use a pump, check for malfunctions or blockages, as insulin delivery issues can cause high blood sugar. If you take injections, make sure you're using the correct dose and injecting properly. After taking insulin, wait at least 2 hours before taking more to prevent a dangerous drop. Keep drinking water to help flush out excess sugar, and monitor your blood sugar closely. If your levels don’t start improving or you have ketones, follow your emergency plan and seek medical help if needed.",
                "Ketones are harmful acids that form when your body starts burning fat for energy instead of glucose due to a lack of insulin. High blood sugar levels, like 250 or higher, can lead to ketone buildup, which can be dangerous and cause diabetic ketoacidosis (DKA). If you notice ketones, it’s important to drink plenty of water to help flush them out, take insulin as directed by your doctor, and avoid exercise since it can make things worse. Keep an eye on your blood sugar and ketone levels, and if symptoms like nausea, vomiting, or confusion appear, seek medical help immediately to prevent serious complications.",
                "Water is crucial when blood sugar is 250 or higher because it helps your body remove excess glucose through urination, preventing further complications. When blood sugar is high, the body pulls water from cells to dilute the extra sugar in the bloodstream, increasing the risk of dehydration. Drinking plenty of water helps replenish lost fluids, supports kidney function, and speeds up the process of flushing out excess sugar before it can cause more harm. Lowering blood sugar sooner with water reduces stress on the kidneys and prevents the buildup of ketones, which can lead to diabetic ketoacidosis (DKA), a life-threatening condition. It also helps relieve symptoms like fatigue, headaches, and dry mouth that come with high blood sugar. The sooner you bring your levels down with water, insulin (if needed), and monitoring, the better you’ll feel and the lower your risk of serious complications.");

                Console.WriteLine();
                extremeHigh.Base();
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeHigh.GetNextStepsEH());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeHigh.GetInsulinEH());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeHigh.GetKetonesEH());
                Thread.Sleep(5000);
                Console.WriteLine();
                Console.WriteLine(extremeHigh.GetWaterEH());
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("");

            EmergencyInfo welcome = new EmergencyInfo("First off, you are not alone. A Type 1 Diabetes diagnosis can feel overwhelming at first, but many people live full, healthy, and active lives with it. The key is understanding how T1D works and learning how to manage it.", 
                "At its core, Type 1 Diabetes is an autoimmune condition.This means the body's immune system mistakenly attacks the insulin-producing cells in the pancreas. Because of this, the body can no longer make insulin, which is essential for turning food into energy. Without insulin, sugar (glucose) stays in the bloodstream instead of getting into cells where it’s needed. This leads to high blood sugar levels, which, if not managed, can cause both short-term and long-term health issues. The good news? Insulin therapy and careful blood sugar management allow people with Type 1 Diabetes to live normal, healthy lives.It takes daily attention, but over time, managing T1D becomes second nature. Most importantly, you are not alone in this journey—there is a whole community, along with doctors, educators, and other families, who can support you every step of the way.",
                "Learning to take control of your health and well-being is no small task, and the fact that you've taken this step speaks volumes about your strength and determination. Managing Type 1 Diabetes—or supporting a loved one who has it—is a journey, not a destination.You will keep learning, growing, and adapting, and that’s okay.The most important thing is that you now have the knowledge and tools to take charge with confidence. Thank you for investing in yourself and your future.Keep moving forward with courage, confidence, and self - compassion.You’ve got this!" 
                );

            Console.WriteLine(welcome.GetIntro());
            Thread.Sleep(10000);
            Console.WriteLine();
            Console.WriteLine(welcome.GetInfo());
            Thread.Sleep(15000);
            Console.WriteLine("");

            p.DisplayInfoChoice();

            Console.Write("\n> ");
            string InfoChoice = Console.ReadLine();
            Console.WriteLine();
            

            if (InfoChoice == "1")
            {
                EmergencyLow low = new EmergencyLow("First off, you are not alone. A Type 1 Diabetes diagnosis can feel overwhelming at first, but many people live full, healthy, and active lives with it. The key is understanding how T1D works and learning how to manage it.", 
                "At its core, Type 1 Diabetes is an autoimmune condition.This means the body's immune system mistakenly attacks the insulin-producing cells in the pancreas. Because of this, the body can no longer make insulin, which is essential for turning food into energy. Without insulin, sugar (glucose) stays in the bloodstream instead of getting into cells where it’s needed. This leads to high blood sugar levels, which, if not managed, can cause both short-term and long-term health issues. The good news? Insulin therapy and careful blood sugar management allow people with Type 1 Diabetes to live normal, healthy lives.It takes daily attention, but over time, managing T1D becomes second nature. Most importantly, you are not alone in this journey—there is a whole community, along with doctors, educators, and other families, who can support you every step of the way.",
                "Learning to take control of your health and well-being is no small task, and the fact that you've taken this step speaks volumes about your strength and determination. Managing Type 1 Diabetes—or supporting a loved one who has it—is a journey, not a destination.You will keep learning, growing, and adapting, and that’s okay.The most important thing is that you now have the knowledge and tools to take charge with confidence. Thank you for investing in yourself and your future.Keep moving forward with courage, confidence, and self - compassion.You’ve got this!", 
                "Recognizing a Low Blood Sugar Emergency: A low blood sugar(hypoglycemia) emergency happens when blood glucose levels drop below 70 mg / dL(or as directed by a doctor).This can happen quickly, especially after exercise, too much insulin, or missing a meal. Common symptoms include: Shakiness or dizziness, Sweating, Confusion or difficulty concentrating, Irritability or sudden mood changes, Weakness or fatigue, Hunger, Blurry vision, and Fast heartbeat. If blood sugar drops too low and is not treated, it can lead to unconsciousness or seizures.This is why fast action is necessary.",
                "Step 1: Follow the 15-15 Rule! The best way to treat a low blood sugar emergency (if the person is awake and able to eat) is to use the 15-15 rule: 1️⃣ Eat or drink 15 grams of fast-acting carbohydrates 2️⃣ Wait 15 minutes and check blood sugar again 3️⃣ If blood sugar is still below 70 mg/dL, repeat the process. Once blood sugar returns to normal, eat a small protein-based snack (like peanut butter or cheese with crackers) to prevent another drop.",
                "Step 2: Best Fast-Acting Carbohydrates for Emergency Lows! Not all foods work the same way. In an emergency low, you need fast-acting, simple carbohydrates (without fat or protein) because they absorb quickly into the bloodstream. ✅ Good options (15g carbs each): 4 oz (½ cup) juice (apple, orange, grape), 4 oz (½ cup) regular soda (NOT diet), Glucose tablets (3-4 tablets), Glucose gel (one tube), 1 tablespoon honey or sugar, 6-7 small candies (like Smarties or Skittles), 5-6 gummy bears. Tip: Always carry at least one of these items with you at all times!",
                "Step 3: What to Do If the Low Doesn't Improve! If, after two rounds of the 15-15 rule, blood sugar does not rise above 70 mg/dL, or the person is: ⚠ Still feeling symptoms, ⚠ Too confused to eat, ⚠ Becoming unresponsive: ➡ Call 911 or use glucagon immediately. (Glucagon is an emergency injection that raises blood sugar quickly and is used when the person cannot eat or drink.)",
                "Step 4: Preventing Future Lows! Once the emergency is over, take steps to avoid another low: ✔ Eat a balanced meal or snack with protein + complex carbs (like a turkey sandwich or yogurt with fruit), ✔ Monitor blood sugar regularly, especially before and after exercise, ✔ Adjust insulin doses if lows are happening frequently (talk to a doctor).💡 Pro Tip: Always carry fast-acting carbs (like juice boxes or glucose tablets) in your bag, car, or pocket so you're prepared for any situation.",
                "Lows can happen, but knowing how to treat them quickly with the right foods can prevent a serious emergency. With time, you’ll learn how your body reacts to different situations, helping you stay in control.",
                "Glucagon is a lifesaving hormone that raises blood sugar when it drops dangerously low. It works by telling the liver to release stored glucose into the bloodstream, which helps bring blood sugar back to a safe level. While fast-acting carbohydrates like juice or glucose tablets are the first choice for treating mild to moderate lows, glucagon is necessary when the person is unconscious, having a seizure, or too confused to eat or drink safely. In these cases, do not attempt to give food or liquids, as this could cause choking. Instead, administer glucagon immediately. There are three main types available: the traditional glucagon injection kit, which requires mixing a powdered glucagon with a liquid before injecting it into the thigh or arm; the Gvoke HypoPen, a pre-mixed auto-injector that works like an EpiPen and requires no preparation; and Baqsimi, a nasal powder that is sprayed into the nose and absorbs through the membranes without requiring inhalation. Once glucagon is given, blood sugar should begin to rise within 5 to 15 minutes, but the person may feel nauseous, vomit, or experience grogginess as they recover. As soon as they are awake and able to swallow, they should eat a small snack containing both carbohydrates and protein to prevent another drop in blood sugar. Even if they recover quickly, it is important to follow up with a doctor or seek medical attention, especially if they were unconscious or had a seizure. Because severe lows can happen unexpectedly, it is essential to carry glucagon at all times and ensure that family members, friends, teachers, or caregivers know how to use it. Additionally, check expiration dates regularly and replace expired glucagon to ensure it will work when needed. While glucagon is a crucial emergency treatment, it is always best to prevent severe lows when possible by monitoring blood sugar levels, recognizing early symptoms, and treating mild lows with fast-acting carbohydrates before they become more serious. Understanding when and how to use glucagon provides an extra layer of safety and ensures that severe low blood sugar emergencies can be handled quickly and effectively.",
                "A hospital visit may be necessary for severe low or high blood sugar emergencies that cannot be managed at home. If a person experiences a severe low and becomes unconscious, has a seizure, or does not respond to glucagon, they should be taken to the hospital immediately. Likewise, if a high blood sugar emergency occurs, such as diabetic ketoacidosis (DKA), which is marked by extreme thirst, vomiting, confusion, rapid breathing, and a fruity odor on the breath, urgent medical care is required. Upon arrival, medical staff will check blood sugar levels, ketones, and electrolyte balance to assess the severity of the situation. For severe lows, they may administer an intravenous (IV) glucose solution to quickly raise blood sugar, and for DKA, they will provide fluids, insulin, and electrolytes to stabilize the body. A hospital stay can last anywhere from a few hours for mild cases to several days if complications arise. After stabilization, doctors may review insulin dosages, dietary habits, and potential causes of the emergency to help prevent future occurrences. It is essential to seek medical help if a low blood sugar episode cannot be corrected with food or glucagon, if persistent vomiting prevents fluids and food intake, or if blood sugar remains dangerously high despite taking insulin. Understanding when to go to the hospital ensures that life-threatening complications are treated quickly while also helping prevent future emergencies through proper diabetes management.");
                
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
                EmergencyHigh high = new EmergencyHigh("First off, you are not alone. A Type 1 Diabetes diagnosis can feel overwhelming at first, but many people live full, healthy, and active lives with it. The key is understanding how T1D works and learning how to manage it.", 
                "At its core, Type 1 Diabetes is an autoimmune condition.This means the body's immune system mistakenly attacks the insulin-producing cells in the pancreas. Because of this, the body can no longer make insulin, which is essential for turning food into energy. Without insulin, sugar (glucose) stays in the bloodstream instead of getting into cells where it’s needed. This leads to high blood sugar levels, which, if not managed, can cause both short-term and long-term health issues. The good news? Insulin therapy and careful blood sugar management allow people with Type 1 Diabetes to live normal, healthy lives.It takes daily attention, but over time, managing T1D becomes second nature. Most importantly, you are not alone in this journey—there is a whole community, along with doctors, educators, and other families, who can support you every step of the way.",
                "Learning to take control of your health and well-being is no small task, and the fact that you've taken this step speaks volumes about your strength and determination. Managing Type 1 Diabetes—or supporting a loved one who has it—is a journey, not a destination.You will keep learning, growing, and adapting, and that’s okay.The most important thing is that you now have the knowledge and tools to take charge with confidence. Thank you for investing in yourself and your future.Keep moving forward with courage, confidence, and self - compassion.You’ve got this!", 
                "When blood sugar levels rise too high, typically above 250 mg/dL, it is important to take action to bring them back to a safe range before more serious complications, like diabetic ketoacidosis (DKA), develop. The first step is to check blood sugar levels and look for patterns to determine if the high is a temporary spike or part of a longer trend. If ketone strips are available, testing for ketones in the urine can help assess whether the situation is becoming more serious. A ketone level of 0.6 mmol/L or lower is considered normal, but if levels begin to rise, it may indicate that the body is struggling to regulate blood sugar, and high ketone levels can lead to a medical emergency. If ketones remain in a safe range, the primary focus should be on bringing blood sugar down safely through a combination of insulin, hydration, and light movement. If insulin is part of the treatment plan, a correction dose should be administered as instructed by a doctor or insulin pump settings. Hydration is also crucial because high blood sugar can lead to dehydration, so drinking plenty of water helps flush out excess glucose through the urine. Light physical activity, such as walking, can help the body use up extra glucose, but intense exercise should be avoided, as it may actually cause blood sugar to rise further. After taking these steps, blood sugar should be checked again in one to two hours to see if levels are improving. If blood sugar remains dangerously high despite taking insulin, if ketones rise above 0.6 mmol/L, or if symptoms like nausea, vomiting, confusion, or extreme fatigue develop, medical attention may be necessary to prevent the onset of DKA. Managing an emergency high before it progresses ensures that blood sugar remains within a safer range and reduces the risk of hospitalization or severe complications.",
                "Ketones are chemicals produced by the body when it breaks down fat for energy instead of using glucose. This can happen when there is not enough insulin available to allow glucose into the cells, forcing the body to rely on fat as an alternative fuel source. While small amounts of ketones (0.6 mmol/L or lower) can be normal, especially during fasting or prolonged exercise, high levels indicate that the body is unable to properly regulate blood sugar. Excess ketones make the blood more acidic, which can lead to serious health risks if not addressed. Monitoring ketone levels is important when blood sugar is high, as rising ketones can signal a developing emergency that requires medical intervention.",
                "Diabetic ketoacidosis (DKA) is a life-threatening condition that occurs when ketone levels become dangerously high, causing the blood to turn acidic. This happens when the body does not have enough insulin to use glucose for energy, leading to a buildup of ketones in the bloodstream. Symptoms of DKA include extreme thirst, nausea, vomiting, abdominal pain, rapid breathing, confusion, and a fruity odor on the breath. If untreated, DKA can lead to coma or death, making immediate medical attention necessary. Treatment for DKA usually involves IV fluids, insulin, and electrolyte replacement at a hospital to restore balance in the body and lower ketone levels safely. The best way to prevent DKA is by monitoring blood sugar levels, checking ketones when blood sugar is high, staying hydrated, and taking insulin as prescribed. Recognizing the early warning signs and taking action quickly can prevent the condition from becoming a medical emergency.",
                "If diabetic ketoacidosis (DKA) occurs and a hospital is not an option, immediate steps must be taken to manage the condition and prevent it from worsening. The first priority is to bring blood sugar down with insulin if available. If using multiple daily injections, a correction dose of rapid-acting insulin should be taken based on the individual’s insulin sensitivity and correction factor. If using an insulin pump, it should be checked for malfunctions, as pump failures are a common cause of DKA. If high blood sugar continues despite taking insulin, injections with a fresh insulin vial or pen should be used instead of the pump. Staying hydrated is critical, as DKA causes severe dehydration. Drinking plenty of water helps flush out excess glucose and ketones, while electrolyte-rich fluids like broth or sugar-free sports drinks can help replenish lost sodium and potassium. Ketone levels should be monitored frequently, and if they continue to rise despite insulin and hydration, extra insulin may be needed—though doses should be adjusted carefully to avoid dangerous drops in blood sugar. Resting is important, but deep breathing exercises can help prevent further acid buildup in the blood. If nausea or vomiting occurs and fluids cannot be kept down, small sips should be taken every few minutes to prevent worsening dehydration. Even if symptoms begin to improve, continued monitoring is essential, as DKA can progress rapidly. While these steps may help temporarily manage DKA, a hospital is still the safest place for treatment, and medical help should be sought as soon as possible, even if that means contacting emergency services, a doctor, or a telehealth provider for guidance. DKA is a life-threatening condition, and home management should only be used as a last resort when no other medical options are available.",
                "When arriving at the hospital for a high blood sugar emergency, medical staff will begin by assessing blood glucose levels, ketone levels, electrolyte balance, and overall hydration status. If diabetic ketoacidosis (DKA) is suspected, they may perform blood tests to check for signs of acidosis and dehydration, as well as a urine test to measure ketones. The primary treatment for severe high blood sugar and DKA is IV insulin therapy, which works to lower blood glucose safely while stopping ketone production. Because DKA causes dehydration, IV fluids will be administered to restore lost fluids and electrolytes like potassium and sodium, which are crucial for heart and muscle function. Patients may also receive oxygen or other supportive care if they are experiencing breathing difficulties, confusion, or severe weakness. As treatment progresses, blood sugar and ketone levels will be monitored closely, and insulin doses will be adjusted to ensure a safe recovery. Most people with DKA require several hours to a couple of days in the hospital, depending on the severity of the condition. Once stabilized, doctors will work with the patient to determine the cause of the emergency, whether it was due to missed insulin doses, illness, pump failure, or another factor, and help adjust their treatment plan to prevent future occurrences. Being admitted for a high blood sugar emergency can be overwhelming, but hospital treatment is the safest way to correct DKA and prevent life-threatening complications like organ failure or coma. After discharge, close monitoring, hydration, and insulin adjustments are essential to ensure continued recovery at home.");
            
                Console.WriteLine();
                Console.WriteLine(high.GetBasicHigh());
                Thread.Sleep(10000);
                Console.WriteLine();
                Console.WriteLine(high.GetKetones());
                Thread.Sleep(15000);
                Console.WriteLine();
                Console.WriteLine(high.GetKetoacidosis());
                Thread.Sleep(15000);
                Console.WriteLine();
                Console.WriteLine(high.GetKetoacidosisHome());
                Thread.Sleep(15000);
                Console.WriteLine();
                Console.WriteLine(high.GetHospitalHigh());
                Thread.Sleep(15000);
                Console.WriteLine();
                Console.WriteLine(high.GetExit());
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