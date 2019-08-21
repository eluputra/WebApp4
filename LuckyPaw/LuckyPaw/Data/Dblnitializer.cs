using LuckyPaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyPaw.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LuckyPawContext context)
        {
            context.Database.EnsureCreated();

            // Look for any prices.
            if (context.PricingPuppyModel.Any())
            {
                return;   // DB has been seeded
            }
            
            var pricesPuppyArr = new PricingPuppyModel[]
            {
                new PricingPuppyModel { PricePuppyDesc = "Daisy, (Golden Retriever, female, 5 weeks)",   PricePuppy = 2000,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/Golden1.jpg", PuppyQty = 1 },
                new PricingPuppyModel { PricePuppyDesc = "Tasha, (German Shepherd, female, 11 weeks) ",   PricePuppy = 2500,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/German1.jpg", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = " Ted (Border Collie, male, 4 weeks)",   PricePuppy = 1500,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/Border1.jpg", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Solo (Belgian Malinois, male, 8 weeks)",   PricePuppy = 3500,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/Belgian1.jpg", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Piper (Golden Retriever, male, 4 weeks)",   PricePuppy = 2200,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/Golden2.jpg", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Chip (Border Collie, male, 6 weeks)",   PricePuppy = 1600,
                    PricePuppyImageUrl = "https://mysqlconnector1.000webhostapp.com/Border2.jpg", PuppyQty = 1  }
              
            };

            foreach (PricingPuppyModel pPuppyModel in pricesPuppyArr)
            {
                context.PricingPuppyModel.Add(pPuppyModel);
            }

            context.SaveChanges();
            
            // TrainingId cannot be the same because trainingId is the key, so
            // if you make trainingId the same, there would be a database seed error
            // For the TrainingId, you cannot set values for this column because it is a primary key, it auto increments
            var trainingArr = new TrainingDogModel[]
            {
                new TrainingDogModel { DogName = "Arrow",
                    TrainerId = "Izzy Artha", GraduationDate = DateTime.Parse("09-07-2016"),
                    TrainingType = "Obedience 2" },
                new TrainingDogModel { DogName = "Archie",
                    TrainerId = "Lely Loi", GraduationDate = DateTime.Parse("10-05-2016"),
                    TrainingType = "Service Dog" },
                new TrainingDogModel { DogName = "Jumbo",
                    TrainerId = "Laura Misty", GraduationDate = DateTime.Parse("03-27-2017"),
                    TrainingType = "Obedience 1" },
                new TrainingDogModel { DogName = "Zizi",
                    TrainerId = "Keshi Tara", GraduationDate = DateTime.Parse("09-15-2017"),
                    TrainingType = "Therapy Dog" },
                new TrainingDogModel { DogName = "Lala",
                    TrainerId = "Lely Loi", GraduationDate = DateTime.Parse("10-26-2017"),
                    TrainingType = "Therapy Dog" },
                new TrainingDogModel { DogName = "Max",
                    TrainerId = "Laura Misty", GraduationDate = DateTime.Parse("01-10-2018"),
                    TrainingType = "Behavior training" },
                new TrainingDogModel { DogName = "Lin Lin",
                    TrainerId = "Reza Sumanto", GraduationDate = DateTime.Parse("01-16-2018"),
                    TrainingType = "Obedience 3" },
                new TrainingDogModel { DogName = "Haiiro",
                    TrainerId = "Lely Loi", GraduationDate = DateTime.Parse("07-02-2018"),
                    TrainingType = "Service Dog" },
                new TrainingDogModel { DogName = "Chi Chi",
                    TrainerId = "Laura Misty", GraduationDate = DateTime.Parse("05-05-2019"),
                    TrainingType = "Obedience 2" },
                new TrainingDogModel { DogName = "Yana",
                    TrainerId = "Laura Misty", GraduationDate = DateTime.Parse("03-25-2019"),
                    TrainingType = "Behavior Training" },
                new TrainingDogModel { DogName = "Azril",
                    TrainerId = "Reza Sumanto", GraduationDate = DateTime.Parse("11-05-2019"),
                    TrainingType = "Service Dog" },
                new TrainingDogModel { DogName = "Lele",
                    TrainerId = "Reza Sumanto", GraduationDate = DateTime.Parse("12-07-2019"),
                    TrainingType = "Protection Dog" }
            };

            foreach (TrainingDogModel trainingDog in trainingArr)
            {
                context.TrainingDogModel.Add(trainingDog);
            }

            context.SaveChanges();

            var trainingServicesPriceArr = new TrainingServicesPriceModel[]
            {
                new TrainingServicesPriceModel { TrainingName = "Obedience Level 1",
                    PriceTraining = 600, TrainingDesc = "Level 1 teaches your dog how fun it can be to follow commands" +
                    "and lays the groundwork for skills that are key in developing a well-mannered canine companion.  " +
                    "You may be surprised at how readily your dog will learn new things — it’s all about consistency! " +
                    "Basic skills taught in Level 1 training include: Stationary attention and name recognition" +
                    "Sit (verbal and hand signals)"+
                    "Polite greeting of people who approach you and your dog" +
                    "Intro to loose-leash walking"
                    },
                new TrainingServicesPriceModel { TrainingName = "Obidiance level 2",
                    PriceTraining = 1000, TrainingDesc = "You’ll continue developing the skills you learned in Level 1 and begin introducing training" +
                    "exercises that are more challenging and useful in the real world. In Level 2, we’ll work on:" +
                    "Automatically sitting when you stop walking (great for icy sidewalks)" +
                    "Going to a mat" +
                    "Laying down" +
                    "Coming when called"
                    },
                new TrainingServicesPriceModel { TrainingName = "Obedience Level 3 ",

                    PriceTraining = 1500, TrainingDesc = "Our level 3 program consits of all of the level 2 and 3 program but with much more advanced off leash training such as off leash heel(sport dog attention heel for example), walking with your dog and saying" + 
                    "\"down\"" + 
                    "and he/she does so as soon as the handler says, sit command from a far distance, come when called from a distance and recall. Of course we combine all of the advanced obedience training around distractions. Our level 3 program is 4-5 weeks long and comes with a 2 hour go home lesson to go over the training and follow up lessons to keep up with the training"
                    },
                new TrainingServicesPriceModel { TrainingName = "Therapy Dog Training",
                    PriceTraining = 1700, TrainingDesc = "Therapy Dogs need to be prepared for all kinds of distractions, able to respond with calm grace and environmental stability." +
                    "In other words – they need to maintain composure and a good sense of humor when, for instance, they are draped in flowing orange Hawaiian leis!" +
                    "While leis aren’t necessarily the most common item you’d find in hospitals or nursing homes – some of the locales where Therapy Dogs are so much in need – there you will find I.V.tubes, rattling wheelchairs and gurneys, cascades of cords from various medical apparatus, and so many other foreign objects"
                    },
                new TrainingServicesPriceModel { TrainingName = "Service Dog Training",
                    PriceTraining = 2500, TrainingDesc = "Along with teaching dogs to assist the disabled in certain functions, trainers familiarize dogs with human interaction and teach basic obedience skills, such as walking in pace with handlers and sitting on command. The training process is comprised of many small tasks, each with instruction techniques. For example, some trainers may use the bridge technique, which involves rewarding dogs every time they perform certain actions. Trainers also provide dogs with physical and mental exercise during the training process. After training is complete, they match dogs with their owners and teach the two to work together. "
                    },
                new TrainingServicesPriceModel { TrainingName = "Behavior Modification Training",
                    PriceTraining = 2500, TrainingDesc = "Our behavior modification program and level 3 advanced obedience training included is a 30 day program where we work with dog aggression, human aggresssion,anxiety, anxious to be out and about and seperation anxiety. Our goal is to work on YOUR top priorty and help eliminate the negative behaviors he/she may have. Our 30 day program consists of our level 3 advanced obedience training that includes level 1 and 2 (see obedience board and train tab on site), help with your top priority, eliminating the negative behaviors, socialiation training/enviromental training. "
                    },
                new TrainingServicesPriceModel { TrainingName = "Protection Dog Training",
                    PriceTraining = 9000, TrainingDesc = "Titled in one of the following: KNPV, French Ring, or Schutzhund" +
                    "Defend handler from vehicle." +
                    "Perform a security check for persons in office or residence." +
                    "Advanced off leash obedience" +
                    "Perimeter search" +
                    "Ability to direct K - 9 to alternate attacker." +
                    "Escort and re - attack(K - 9 will escort prisoner to desired location and will bite and hold, if prisoner re - attacks or tries to escape.)" +
                    "Alert on command(bark and show signs of aggression, on - leash)" +
                    "Bite and hold(apprehend attacker and hold until release is given, off - leash)" +
                    "Release and guard on command(release bite and guard attacker, off - leash)" +
                    "Pursue and apprehend(K - 9 will chase, bite and hold attacker, off - leash)" +
                    "Acclimated to living in home setting" +
                    "Exposed to a variety of environments." +
                    "Passed extensive health check, to include x-rays" +
                    "Full Warranty"
                    },
                new TrainingServicesPriceModel { TrainingName = "Agility Dog Training",
                    PriceTraining = 1500, TrainingDesc = "Agility is one of the fastest-growing dog sports in the country—and for good reason. It’s incredible exercise for both you and your dog, and it forges an even deeper relationship between you. Plus, it’s exhilarating to watch as your dog nimbly and quickly crawls through tunnels, weaves around poles, and leaps through tires!"
                    },

                new TrainingServicesPriceModel { TrainingName = "Hunting Dog Training",
                    PriceTraining = 2000, TrainingDesc = "Training a hunting dog should be fun process for both puppy and owner. Relax, be consistent, and speak softly. Years of fun are in your future."
                    }
            };

            foreach (TrainingServicesPriceModel trainingServicesPrice in trainingServicesPriceArr)
            {
                context.TrainingServicesPriceModel.Add(trainingServicesPrice);
            }

            context.SaveChanges();

            var trainersArr = new TrainersModel[]
            {
                new TrainersModel { TrainerId = "Izzy Artha",
                    TrainerName = "Izzy Artha", TrainerArea = "Obedience",
                    DogNumber = 5
                    },
                 new TrainersModel { TrainerId = "Lely Loi",
                    TrainerName = "Lely Loi", TrainerArea = "Service Dog, Hunting Dog, Protection Dog, Obedience, Agility Training",
                    DogNumber = 5
                    },
                new TrainersModel { TrainerId = "Laura Misty",
                    TrainerName = "Laura Misty", TrainerArea = "Obedience, Behavior Training, Therapy Dog, Service Dog",
                    DogNumber = 5
                    },
                 new TrainersModel { TrainerId = "Keshi Tara",
                    TrainerName = "Keshi Tara", TrainerArea = "Therapy Dog, Obedience",
                    DogNumber = 5
                    },
                 new TrainersModel { TrainerId = "Reza Sumanto",
                    TrainerName = "Reza Sumanto", TrainerArea = "Obedience, Service Dog, Protection Dog",
                    DogNumber = 5
                    },
                
            };

            foreach (TrainersModel trainer in trainersArr)
            {
                context.TrainersModel.Add(trainer);
            }

            context.SaveChanges();
        }
    }
}

