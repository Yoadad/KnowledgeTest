namespace KnowledgeTest.DataContexts.KnowledgeTestMigrations
{
    using KnowledgeTest.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KnowledgeTest.DataContexts.KnowledgeTestDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\KnowledgeTestMigrations";
        }

        protected override void Seed(KnowledgeTest.DataContexts.KnowledgeTestDb context)
        {
            var test = new Test { Name = "Scrum Open Assessment" };
            context.Tests.AddOrUpdate(t=>t.Name,test);

            Question question;

            question = new Question { Name = "2.80", Description = " What is the maximum length of a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Not so long that the risk is unacceptable to the Product Owner. ", IsCorrect = false, Value = false, Question = question});
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No more than one calendar month. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Not so long that other business events can't be readily synchronized with the development work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of these answers are correct.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.79", Description = " The Scrum Master should NOT allow the Product Owner to go to the Sprint Planning meeting WITHOUT having already devised the Sprint Goal. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.78", Description = " Which does a self-organizing Development Team choose? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Stakeholders for the Sprint Review ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When to release, based on its progress ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How to best accomplish its work ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint length ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Product Backlog ordering", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.77", Description = " Which of the following is true about Scrum? Choose all that apply. ", Type =  QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is like traditional processes but with self-organization to replace Project Managers.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a methodology, where you can pick and choose which parts of Scrum you think Will work for your environment.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each component of Scrum serves a specific purpose, and is essential to Scrum's success and your usage of Scrum to develop complex products.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a framework for developing and maintaining complex products. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is based on empirical process control theory.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.76", Description = " What happens if the Development Team cannot complete its work by the end of a time-box? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box is adjusted permanently to reflect reality.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box holds and the Development Team continuously learns what is actually possible to do within a time-box.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box is extended temporarily. Lessons are taken to ensure it doesn't happen again.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum should be abandoned.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.75", Description = " The Product Backlog is ordered by: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Safer items at the top to riskier items at the bottom. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Small items at the top to large items at the bottom. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Items are randomly arranged. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whatever is deemed most appropriate by the Product Owner. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Least valuable items at the top to most valuable at the bottom.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.74", Description = " During a Sprint Retrospective, for what is the Scrum Master responsible? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prioritizing the resulting action items. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Participating as a Scrum team member and facilitating as requested or needed.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Acting as a scribe to capture the Development Team's answers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Summarizing and reporting the discussions to management.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.73", Description = " Who has the final say on the order of the Product Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The CEO ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.72", Description = " Development Team members step up to own a Sprint Backlog item: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever a team member can accommodate more work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint planning meeting. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never. Al Sprint Backlog Items are \"owned\" by the entire Development Team, even though each one may be done by an individual Development", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team member. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Daily Scrum.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.71", Description = " A Scrum Master is introducing Scrum to a new Development Team. The Development Team has decided that a retrospective is unnecessay. What action should the Scrum Master take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Consult with the Product Owner to see how he/she feels about the situation. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Comply with the decision of the self-organizing team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Begin facilitating productive and useful retrospectives. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Call a meeting between the Development Team and senior management.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.70", Description = " Which three (3) questions are answered by all Development Team members at the Daily Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How is the Sprint proceeding? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What work did I do yesterday to help the team achieve its goal? ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Why were you late? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What work am I going to do today to help the team achieve its goal? ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How many hours did I spend on the project yesterday? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What impediments are in my way or in the way of the team?", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.69", Description = " A Sprint Retrospective should be held: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of the last Sprint in a project or a release. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of each Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the beginning of each Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Only when the Scrum Team determines it needs one.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.67", Description = " What does it mean for a Development Team to be cross-functional? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is a virtual team drawing from separate teams of business analysts, architects, developers and testers.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team includes not only developers but also business analysts, architects, developers and testers.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team includes cross-skilled individuals who are able to contribute to do what is necessary to deliver an increment of software.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Developers on the Development Team work closely with business analysts, architects, developers and testers who are not on the team.", IsCorrect = false, Value = false, Question = question });
            

            question = new Question { Name = "2.66", Description = " When is the Sprint Backlog created? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the beginning of the project ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint Planning meeting ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to the Sprint Planning meeting ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.65", Description = " During a Sprint, when is new work or further decomposition of work added to the Sprint Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As soon as possible after they are identified. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Scrum Master has time to enter them. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner identifies new work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Daily Scrum after the Development Team approves them.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.64", Description = " During a Sprint Retrospective, for what is the Product Owner responsible? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Summarizing and reporting the discussions to the stakeholders that he/she represents in the Scrum Team.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "He/She doesn't need to be there. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Participating as a Scrum Team member. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Capturing requirements for the Product Backlog.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.63", Description = " What is included in the Sprint Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "User Stories ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Use Cases ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tests ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tasks ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Any of the above (or others) which are a decomposition of the selected Product Backlog items", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.62", Description = " If quality assurance work does not occur as part of the development work within a Sprint, which benefits are lost? Choose all that apply.", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The project manager cannot effectively update the plan. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The indication of progress on the Product Backlog is not transparent. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The increment is probably not releasable. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Future Sprints Will probably be interrupted with bugs that are being found.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.61", Description = " Every Scrum Team must have a Product Owner and Scrum Master. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True. Each must be 100% dedicated to the Scrum Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True. Outcomes are affected by their participation and availability.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.60", Description = " The only person who can abnormally terminate a Sprint is? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team or its members", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.59", Description = " If burndown charts are used to visualize progress, what do they track? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Individual worker productivity ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Accumulated business value delivered to the customer ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Accumulated cost ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Work remaining across time", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.58", Description = " Which answer best describes the topics covered in Sprint Planning? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What went wrong in the last Sprint and what to do differently this Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What to do and who Will do it. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Who is on the team and what team member roles Will be. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How conditions have changed and how the Product Backlog should evolve. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What can be done and how to do it.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.57", Description = " Who must do all the work to make sure Product Backlog items conform to the Definition of \"Done\"?", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "QA Specialists ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Team", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.56", Description = " How many hours per day should a person on a Scrum Team work? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "However many hours are needed to get the work done. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "14 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At a sustainable pace, usually 7-8 hours per day. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An \"ideal day\" measuring only when he or she is productive.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.55", Description = " Why should the Product Owner be present at the Daily Scrum? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To participate as a Scrum Team member. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To represent the stakeholders' point of view. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To hear about impediments in functionality. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "He/She doesn't need to be there.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.54", Description = " Which of the following is NOT a timeboxed event in Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Retrospective ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Daily Scrum ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release Testing ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint 0 ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release Retrospective ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Testing", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.53", Description = " Choose three responsibilities of a self-organizing Development Team. Choose three answers.", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Reorder the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Track velocity. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Report daily progress to stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Pull Product Backlog items for the Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Do the work planned in the Sprint Backlog. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Set the time for the Daily Scrum.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.52", Description = " When multiple Scrum teams are working on the same project, they should make sure that each team has different Sprint start dates. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.51", Description = " Which of the following might the Scrum Team discuss during a Sprint Retrospective? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Methods of communication. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "ts Definition of \"done.\" ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The way the Scrum Team does Sprint Planning. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Skills needed to improve the Development Team's ability to deliver. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al of the above.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.50", Description = " Which technique is the LEAST productive way for the Scrum Master to ensure that the Development Team communicates effectively with the Product Owner? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Act as a go-between for them. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Teach the Team to talk in terms of business needs and objectives. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Teach the Product Owner about the technologies employed during the ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitor communications between them.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.49", Description = " Scrum Master is a \"management\" position? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.48", Description = " When may a Development Team change its engineering practices? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever needed ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During Sprint Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint Retrospective ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to starting a new Sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to starting a new project", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.47", Description = " When a Development Team determines that it has over-committed itself for a Sprint, who has to be present when reviewing and adjusting the Sprint work selected? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master, project manager and Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and the Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and all stakeholders", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.46", Description = " As Scrum Teams mature, it is expected that the following decision is likely to be taken: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Retrospectives Will grow to be longer than 4 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no need for a time-boxed Sprint, since time-boxes are only for new Scrum Teams.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Scrum Master is no longer needed since they are a mature team now. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "They Will improve their definition of \"Done\" to include more stringent criteria. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Reviews Will no longer be needed.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.45", Description = " The purpose of a Sprint is to produce a done increment of working product. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.44", Description = " What are two responsibilities of testers in a Development Team? Choose two answers.", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Verifying the work of programmers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Finding bugs ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum has no \"tester\" role ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tracking quality metrics ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Everyone in the Development Team is responsible for quality", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.43", Description = " Who determines how work is performed during the Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Arch itects ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Development Team managers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Subject matter experts ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.42", Description = " Which of the following are true about the Product Owner role? (Choose 3 answers) ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner role can be played by a committee or a team of people. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner can be influenced by a committee. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Multiple people can share the Product Owner role on a Scrum Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is accountable for ordering the Product Backlog. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is one person.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.41", Description = " Scrum is a methodology that tells in detail how to build software incrementally. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.40", Description = " How often should Development Team membership change? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just as it would on any development team, with no special allowance for ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "changes in productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As needed, while taking into account a short term reduction in productivity. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never, because it reduces productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Every Sprint to promote shared learning.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.39", Description = " Items on the Product Backlog tend to be: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Larger than the items in the Sprint Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "t depends. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The same size as the items in the Sprint Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Smaller than the items in the Sprint Backlog.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.38", Description = " When many Development Teams are working on a single product, what best describes the definition of \"Done?\" ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each Development Team uses its own but must make their definition clear to all other Teams so the differences are known.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al Development Teams must have a definition of \"Done\" that makes their combined work potentially releasable.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each Development Team defines and uses its own. The differences are discussed and reconciled during a hardening Sprint.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It depends.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.36", Description = " How much of the Sprint Backlog must be defined during the Sprint Planning meeting? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just enough to understand design and architectural implications. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Enough so the Development Team can create its best forecast of what it can do, and to start the first several days of the Sprint.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al of the potential work. The Sprint Planning meeting isn't over until 100% of the work is identified and estimated.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just enough tasks for the Scrum Master to be confident in the Development Team's understanding of the Sprint.", IsCorrect = false, Value = false, Question = question });
            

            question = new Question { Name = "2.35", Description = " Which is NOT a Development Team responsibility? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Optimizing the work required to meet the Sprint Goal at least daily ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Selecting the Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Resolving internal team conflicts ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Planning how to meet a Sprint Goal ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitoring productivity", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.34", Description = " Which of these may a Development Team deliver at the end of a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An increment of working software that is \"done.\" ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A single document, if that is what the Scrum Master asked for. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Failing unit tests, to identify acceptance tests for the next Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An increment of software with minor known bugs in it.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.33", Description = " Who is on the Scrum Team? Choose all that apply.", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Project Manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "None of the above", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.32", Description = " Which of the following is true about the Scrum Master role? Choose all that apply.", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint Review, the Scrum Master identifies what has been \"done\" and what has not been \"done\".", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master is responsible for updating the Sprint Burndown. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master helps those outside the team interact with the Scrum Team.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master teaches the Development Team to keep the Scrum meetings to their timebox.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master assigns tasks to Development Team members when they need work.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.31", Description = " Which statement best describes a Product Owner's responsibility? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Keeping stakeholders at bay. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Managing the project and ensuring that the work meets the commitments to ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "the stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Optimizing the value of the work the Development Team does. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Directing the Development Team.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.30", Description = " The Development Team should not be interrupted during the Sprint. The Sprint Goal should remain intact. These are conditions that foster creativity, quality and productivity. Based on this, which of the following is FALSE? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As a decomposition of the selected Product Backlog Items, the Sprint Backlog changes and may grow as the work emerges.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner can help clarify or optimize the Sprint when asked by the Development Team.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Backlog and its contents are fully formulated in the Sprint Planning meeting and do not change during the Sprint.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team may work with the Product Owner to remove or add work if it finds it has more or less capacity than it expected.", IsCorrect = false, Value = false, Question = question });
            

            question = new Question { Name = "2.29", Description = " Which three (3) activities Will a Product Owner likely engage in during a Sprint? Choose 3 answers.", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Answer questions from the Development Team about items in the current Sprint.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Run the Daily Scrum. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Provide feedback. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prioritize the Development Team's tasks. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Work with the stakeholders. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Update the Sprint burndown chart.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.28", Description = " The Product Owner must ship each Sprint increment. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Choose one answer. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To make sure the Development Team is done every Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When it makes sense. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever the product is free of defects. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Without exception.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.27", Description = " The time-box for the Sprint Review is? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of every Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours for a 4 week Sprint. Usually shorter for shorter Sprints. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "However long is needed. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "15 minutes.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.26", Description = " When many Scrum Teams are working on the same product, should all of their increments be integrated every Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No, that is far too hard and must be done in a hardening Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No, each Scrum Team stands alone. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Yes, but only for Scrum Teams whose work has dependencies. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Yes, otherwise the Product Owners (and stakeholders) may not be able to accurately inspect what is done.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.25", Description = " Why does a Development Team need a Sprint Goal? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is more focused with a common yet specific goal. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Goals are not valuable. Everything is known from the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Sprint Goal ensures that all of the Product Backlog items selected for the Sprint are implemented.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Sprint Goal only gives purpose to Sprint 0.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.24", Description = " A Scrum Master is working with a Development Team that has members in different physical locations. The Development Team meets in a variety of meeting rooms and has much to do logistically (for example, set up conference calls) before the Daily Scrum. What action should the Scrum Master take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Allow the Development Team to self-manage and determine for itself what to do.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ask the Development Team members to alternate who is responsible for meeting setup. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inform management and ask them to solve it. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Set up the meeting and tell the Development Team that is how it Will be done.", IsCorrect = true, Value = false, Question = question });
            

            question = new Question { Name = "2.23", Description = " The maximum length of the Sprint Review (its timebox) is: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As long as needed. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "1 day. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "2 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours for a monthly Sprint. For shorter Sprints it is usually shorter. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours and longer as needed.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.22", Description = " Who is responsible for tracking the remaining work of the Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team in consultation with the Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Project Manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.21", Description = " What are three benefits of self-organization? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased commitment ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased rule compliance ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased creativity ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased predictability ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased self-accountability", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.20", Description = " An abnormal termination of a Sprint is called when? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When it is clear at the end of a Sprint that everything won't be finished. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When Sales has an important opportunity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner determines that it makes no sense to finish it. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Team feels that the work is too hard.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.19", Description = " Which phrase best describes a Product Owner? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Go-between between development team and customers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Value optimizer ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Requirements engineer", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.18", Description = " A Sprint Review is the only time that the stakeholders and the Scrum Team can come together. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.17", Description = " Which output from Sprint Planning provides the Development Team with a target and overarching direction forthe Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The release plan ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Goal ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Review minutes", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.16", Description = " While under development, the environment in which a product Will be used changes and emerges. What is the effect on the Product Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt is archived and a new Product Backlog is created to take its place. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The requirements specification document, describing the Product Backlog items, must be updated to ensure stability.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no effect, because it has to stay the same until the end of the project.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt evolves to reflect what the product needs to be most valuable.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.15", Description = " For the purpose of transparency, when does Scrum say a new increment of working software must be available? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Before the release Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Every 3 Sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "After the acceptance testing phase. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner asks to create one. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of every Sprint.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.14", Description = " The Product Owner makes sure the team selects enough from the Product Backlog for a Sprint to satisfy the stakeholders. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.13", Description = " Which are NOT appropriate topics for discussion in a Sprint Retrospective? (Choose 2 answers) ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team relations ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Definition of \"Done\" ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How the team does its work ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Backlog for the next Sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The value of work currently represented in the Product Backlog", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.12", Description = " During the Sprint, the Scrum Master's role is to: ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Escalate team conflicts to functional line managers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ensure the Product Owner attends all Scrum events. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Remove impediments. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitor the progress of the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Assign tasks with the Scrum team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Facilitate inspection and adaption opportunities as requested or needed.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.11", Description = " Which of the following best describes an increment of working software? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Additional features in a useable state that complement those delivered in previous iterations. ", IsCorrect = true, Value = false, Question = question });
            
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An automated test suite to verify functionality delivered in previous iterations. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "UML diagrams that describe how to deliver functionality in future iterations. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A decomposition of all Product Backlog items into tasks for future Sprint Backlog lists.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A new user interface design for functionality delivered in previous iterations.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.10", Description = " Which two (2) things does the Development Team NOT do during the first Sprint? Choose 2 answers.", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Develop and deliver at least one piece of functionality. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Nail down the complete architecture and infrastructure. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Develop a plan for the rest of the project. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Deliver an increment of potentially shippable functionality.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.9", Description = " The Product Owner remains distant. He/she has handed over the required Product Backlog for the Sprint but is not collaborating with the Development Team during the Sprint. What are valuable actions for a Scrum Master? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Coach the Product Owner in the values of Scrum and incremental delivery. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Stop the Sprint, send the Product Owner to a course and restart. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inform the Product Owner's functional manager. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Bring up the problem in the Sprint Retrospective. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Nominate a proxy Product Owner.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.8", Description = " Which of the following are feedback loops in Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Choose all that apply. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Review ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Daily Scrum ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Retrospective", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.7", Description = " A new developer is having continuing conflicts with existing Development Team members and creating a hostile environment. If necessary, who is responsible for removing the team member? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is responsible, because he/she controls the return on investment (ROI).", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The hiring manager is responsible, because he/she hired the developer. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master is responsible, because he/she removes Impediments. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is responsible, and may need help from the Scrum Master", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.6", Description = " Who creates a Product Backlog item's estimate? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner with input from the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The most senior people in the organization, including architects and subject matter experts.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team, alone. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team after clarifying requirements with the Product Owner.", IsCorrect = true, Value = false, Question = question });
            

            question = new Question { Name = "2.5", Description = " Scrum does not have a role called \"Project Manager.\" ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.4", Description = " The Scrum Master observes the Product Owner struggling with ordering the Product Backlog. What would you consider an appropriate action for the Scrum Master to take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Encourage the Product Owner to work with the Development Team to see which items technically are fastest to implement.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Suggest that the Development Team does the ordering to be sure that it is a feasible ordering of work.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Suggest the Product Owner extend the Sprint, so he can have more time to order the Product Backlog.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Offer the Product Owner help in ordering the Product Backlog from an understanding that the goal is to maximize value.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Present the Product Owner with an ordered Product Backlog to use.", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.3", Description = " When can a Development Team cancel a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A technical dependency cannot be resolved. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Functional expectations are not well understood. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The forecast for the Sprint becomes un-achievable. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt can't. Only Product Owners can cancel Sprints. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is absent too often. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Answers A or D.", IsCorrect = false, Value = false, Question = question });

        }
    }
}
