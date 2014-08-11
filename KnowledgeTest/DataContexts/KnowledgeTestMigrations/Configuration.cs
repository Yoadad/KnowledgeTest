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
            context.Tests.AddOrUpdate(t => t.Name, test);

            Question question;

            question = new Question { Name = "1.2", Description = " What is the accountability of the Product Owner during Sprint 0? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Make sure enough Product Backlog items are refined to fill the first 3 sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Make the complete project plan to commit date, budget and scope to the stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Gathering, eliciting and analyzing the requirements that will be inserted into the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no such thing as Sprint 0. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Determine the composition of the Development Team so they have the capacity to deliver the completed forecast. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.4", Description = " Who owns the Sprint Backlog ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.5", Description = " Which best describes the Product Backlog ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is allowed to gro and change as more is learned about the prodcut and its customers ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is baselined to follow change management processes. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It contains all foreseeable tasks and requirements from which the Scrum team can develop and maintain a complete project plan. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It Provides just enough information to enable a Scrum team to start the design phase of a product. ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "1.6", Description = " The development Team has forecast and amount of Product Backlog items it thinks it can accomplish and a Sprint Goal. Who determines how the development team accomplishes this work? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Knowledgeable architects or managers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The various functional managers that the Team member report to. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.7", Description = " When is a sprint over? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner says it is done. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When all Product Backlog items meet their definition of DONE. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When all the tasks are completed. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the timebox expires. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.8", Description = " What is the primary way a Scrum Master keeps a Development Team Working as its highest level of productivity? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "By keeping high value features high in the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "By ensuring the meetings start and end at the proper time. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "By preventing changes to the backlogs once the sprint begins. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "By facilitating Development Team decisions and removing impediments. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.9", Description = " Which statement best describes the Sprint Review ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is used to congratule the Development Team if it didi what it commited to doing, or to punish the Development Team if it failed to meet its commitments. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is when the Scrum Team and stakeholders inspect the outcome of the Sprint and figure out what to do in the upcoming Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is a demo at the end of the Sprint for everyone in the organization to provide feedback on the work done. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is a review of the team's activities during the sprint. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.11", Description = " A Scrum Master is keeping a list of open impediments, but it is growing and he/she has been able to resolve only a small portion of the impediments. Which 3 techniques would be most helpful in this situation ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Arrange a triage meeting with all other project managers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Discuss the absence of management support with the Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Priorize the list and work on them in order ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Consult with the Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Alert management to the impediments and their impact ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tell the product owner that the Scrum is not working ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.12", Description = " Which are properties of the Daily Scrum ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It consists of the Scrum Master asking the Team members the three questions ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is held first thing in the morning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is facilitated by the team lead ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is 15 minutes or less in duration ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Its location and time should remain constant ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is free form and designed to promote conversation ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.13", Description = " Which statement best describes the Sprint Backlog as outcome of the Sprint Planning ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is a task list where every Development Team member has signed up for all the tasks that he/she intends to do in the Sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is a decomposition of Product Backlog items such that enough work is decomposed for at least the first days of the sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It must be ordered by the Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is an exhaustive list of all taks for the Sprint. Tasks must be estimated in hours ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Is is a list of the User Stories estimated in story points, and a list of corresponding tasks that are estimated in hours ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.14", Description = " Which of the following is the Development NOT responsible for? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Planning how to meet the Sprint goal ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Resolving internal conflicts ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitoring productivity ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Optimizing the work required to meet the Sprint goal at least daily ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Selecting the Product Owner ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.15", Description = " Why is the Daily Scrum held at the same time and same place ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Rooms are hard to book and this lets it be booked in advance ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The place can be named ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner demands it ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The consistency reduces complexity and overhead ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.16", Description = " How much time is required after a Sprint to prepare for the next sprint ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Enough time for the requirements for the next Sprint to be nailed down ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "None. A new sprint starts immediately following the end of the previous Sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The break between Sprints is time-boxed to 1 week for 30 days Sprints, and usually less for shorter sprints ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Enough time for the Development Team to finish the testing from the last sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of the above are allowed depending of the situation ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.17", Description = " When does a Development Team make adjustements to its engineering practices ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During Sprint Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to start a new project ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever needed ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Before Sprint begins ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "After they have been discussed and agreed to at the Sprint Retrospective ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.18", Description = " Which of the following is required by Scrum ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Members must stand up at the Daily Scrum ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Burndown Chart ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Retrospective ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of the above ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.19", Description = " A Development Team is having difficulty developing a piece of functionality ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "May consult with people outside of the team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Set it aside for the hardening Sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ask the Product Owner to restore it to the Product Backlog ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Do whatever they can and identify the remainder of the work at the Sprint Review ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Must figure it out themselves without outside help ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.20", Description = " Which statement best describes Scrum ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A framework within which complex products in comples environments are developed ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A complete methodology that defines how to develop software ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A cookbook that defines best practices for software development ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A defined and predictive process that conforms to the principles of Scientific Management ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.21", Description = " How much work must a Development Team do to a Product Backlog item it selects for a Sprint ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As much as it has told the Product Owner will be done for every product backlog item it selects in conformance with the definition of DONE ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The best it can do given that it is usually impossible for QA to finish all of the testing that is needed to prove shippability ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Analysis, design, programming, testing and documentation ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As much as it can fit into the Sprint ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.24", Description = " The definition of DONE is used to: ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Describes the purpose, objective and timebox of each Scrum event ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Create a shared understanding of when work is complete ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increase transparency ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Guide the DT on how many PB items to do in a sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Describe the work that must be done before the Sprint can end ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.27", Description = " What are the responsabilities of a tester in a development team ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum has no subroles like tester ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Cheking the work of the programmers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Finding bugs to assure quality ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Creating code coverage reports for the test manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Everyone is reponsible for quality in Scrum ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.29", Description = " When is a Product Backlog item considered complete? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When QA reports that is passes all acceptance criteria ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When all work in the Sprint Backlog that is related to it is complete ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of the sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The item has no work remaining that must still be done before it can be used by its end user ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.31", Description = " Who should know the most about the progress toward a business objective or a release, and be able to explain the alternatives most clearly ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Project Manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.33", Description = " The development team should have all the skills needed to ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Turn the PB items it selects into an incremenet of potentially shippable product functionality ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Do all the development work, but not other types of testing that require specialized testing, tools and environments ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Complete the project as estimated when the date and cost are commited to the product owner ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.34", Description = " Who should make sure everyone does his or her tasks for the Sprint ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The development team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The PO ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The PM ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The SM ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of above ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.35", Description = " What activities would a Product Owner typically undertake in the phase between the current Sprint Review meeting and the next Sprint's Sprint Planning ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Updating the project plan with stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no such activities. The Next sprint starts immediately after the current sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Refining the product backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Working with the Qa departments on the increment of the current sprint ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.38", Description = " Which topics should be discussed in the Sprint Review ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Coding and engineering practices ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint results ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum process, and how it was used during the sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "all of above ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.40", Description = " A self-organizing Development Team in Scrum autonomously chooses ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The ordering of the Product Backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Which stakeholders are needed at the sprint review ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How to best accomplish its work ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The best suited sprint length for their sprint backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the best possible release should occur based on their progress ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.42", Description = " The sprint review is ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A review of the Scrum Team activities and processes during the sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A time allocated to judge the validity of the project ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An opportunity for stakeholders to inspect the product increment and progress and provide feedback on next steps ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Used to build team spirit ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.45", Description = " Sprint burndown charts are an efficient tracking tool because they show ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How much effort has gone into a sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How many product backlog items remain ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An estimate of the total work remaining for the sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How many houws have been worked by each development team member ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.46", Description = " What does it mean to say that an event has a timebox ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The event can take no more than a maximum amount of time ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The event must happen at a set time ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The event must take at least a minimum amount of time ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The event must happen by a given time ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.47", Description = " The product owner determines how many product backlog items the development team select for a sprint ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True, accordingly to that was commited to the stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True, but only after confirmation by the resource manager that the team has enough capacity ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False, the scrum master does that ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False, capacity and commitment are the project manager's responsibility ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.48", Description = " An organization has decided to adopt Scrum, but management wants to change the terminology to fit with terminology already used. What will likely happen if this is done? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The organization may not understand what has changed within Scrum and the benefits of Scrum may be lost ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Management may feel less anxious ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Without a new vocabulary as a reminder of the change, very little change may actually happen ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All answers apply ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.49", Description = " The Development Team informs the Scrum Master that the IT manager has asked them for a status report during the sprint. the Scrum Master will: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Talk to the IT manager and inform him that progress in Scrum comes from inspecting increments at the sprint review ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tell the development team to figure it out themselves ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ask the Product Owner to send the unit manager the report ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tell the Development Team to fit the report into their Sprint Backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Create and deliver the report to the unit manager hersellf ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.51", Description = " What is the main reason for the Scrum Master to be at the Daily Scrum ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To write down any changes to the sprint backlog, including adding new items, and tracking progress on the burndown ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To make sure every team member answers the 3 questions in the right team memeber order ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To gather status and progress information to report to management ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "He or she dow not have to be there, he or she only has to ensure the development team has a daily scrum ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.53", Description = " The timebox for the complete Sprint Planning meeting is? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever it is one ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "8 hours for a monthly Sprint, proportionately less for shorter Sprints ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monthly ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.54", Description = " If burndown charts are used to visualize progress, what does a trend line through a release burndown chart indicate? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the work remaining will likely be completed if nothing changes on the PB or the DT ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the project will be over if the PW removes work that is equal in effort to any new work that is added ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The evolution of the cost spent of the project ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When all work will be completed so the scrum team can be released for other work ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.55", Description = " Which two things does a Scrum Master do if the Development Team doesnt have the engineering tools and infrastructure to completely finish any Product Backlog items? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Has the development team define done and do the same work for all product backlog items it selects ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Has the development team improve its skilss, tools and infrastucture over time and adjust the definition of done accordingly ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Asks the development team to spend as many sprints as necessary to prepare the engineering tools and infrastructure so any PB item it selects is potentially shippeable at sprint end ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Declared the DT not ready for scrum ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Asks the development team to do the best if can on each PB item it selects ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.65", Description = " The primary reason one might choose a four-week Sprint is whe the work is too large for a two-week Sprint and cannot be decomposed further ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.66", Description = " Who is responsible for clearly expressing Product Backlog Items? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master, or the Scrum Master may have the Development Team do it ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The business analyst who represents the PO in the DT ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.67", Description = " A cross-functional team is a team that has the best possible composition to work on one technical layer of a system ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.70", Description = " As the sprint planning meeting progresses, the workload is getting to be greater than the DT's capacity. Which two actions make the most sense to do? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ensures that the PO is aware, starts the sprint and monitor progress ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ask the DT to work overtime for this sprint and promise that it wont happen again ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Start the sprint and recruit additional DT members ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Cancel the sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Remove or change selected PB items ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.73", Description = " It is mandatory that the product increment be released to production at the end of each sprint. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "1.75", Description = " What is NOT a benefit of self-organization to the Scrum Development Team? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased commitment ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased feeling of accountability ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Management can remove a failing resource more easily ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased creativity ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.76", Description = " Who is required to attend the Daily Scrum? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team and PO ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team and Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master and PO ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "1.77", Description = " Who is responsible for engaging the stakeholders ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The business analyst ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The PO ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The project manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The team manager ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.78", Description = " During the Daily Scrum, the Scrum Master's role is to: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Manage the meeting in a way that each team member has a chance to speak. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Make sure that all 3 questions have been answered. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Teach the DT to keep the Daily Scrum within the 15 minute timebox. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Lead the discussions of the DT. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of the above. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "1.80", Description = " Development Team membership should change: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As needed, while taking into account the short term reduction in productivity. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just as it would on any development team, with no special allowance for changes in productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never, because it reduces productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Every sprint to promote shared learning. ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "1.57", Description = " What is the role of Management in Scrum? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To monitor the DT productivity ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To identify and remove people that arent working hard enough ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To continually monitir staffing levels of the DT ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Management supports the Product Owner with insights and information into high value product and system capabilities. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "0.1", Description = " During a Sprint, a Development Team determines that it will not be able to finish the complete forecast. Who should be present to review and adjust the Sprint work selected? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master, the project manager and the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and the Development Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and all stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.2", Description = " What is the recommended size for a Development Team (within the Scrum Team)? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Minimal 7 ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "3 to 9. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "7 plus or minus 2. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "9. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.3", Description = " The CEO asks the Development Team to add a very important item to the current Sprint. What should the Development Team do? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inform the Product Owner so he/she can work with the CEO. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Add the item to the current Sprint without any adjustments. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Add the item to the current Sprint and drop an item of equal size. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Add the item to the next Sprint. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.3", Description = " Upon what type of process control is Scrum based? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Empirical ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Hybrid ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Defined ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Complex ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "0.4", Description = " The three pillars of empirical process control are: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Respect For People, Kaizen, Eliminating Waste ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Planning, Inspection, Adaptation ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Transparency, Eliminating Waste, Kaizen ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inspection, Transparency, Adaptation ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Planning, Demonstration, Retrospective ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.5", Description = " Development Team members volunteer to own a Sprint Backlog item: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint planning meeting. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never. All Sprint Backlog Items are owned by the entire Development Team, bla bla bla.... ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever a team member can accommodate more work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Daily Scrum ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.6", Description = " Which two of the following are true about the Scrum Master role?  ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master is responsible for updating the Sprint Burndown. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint Review, the Scrum Master identifies what has been done and what has not been done ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master helps those outside the team interact with the Scrum Team.	 ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master assigns tasks to Development Team members when they need work.", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master teaches the Development Team to keep the Scrum meetings to their timebox. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "0.7", Description = " For which is the Scrum Master responsible?  ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Managing the performance of the Scrum Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum process being adopted and used properly. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The meetings and the objectives that a Scrum Team sets for itself. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Keeping track of resource allocation. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.8", Description = "What two things might a Development Team do when having trouble delivering a working Increment? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Defer the work to a more appropriate Sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Complete what it can and discuss undone work at the Sprint Review ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Collaborate with the Product Owner to determine what is possible and acceptable ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Add a specialist to the Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Consult with people outside of the Development Team ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "0.9", Description = "Which three of the following are true about Scrum?  ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a methodology, where you can pick and choose which parts of Scrum you think will work for your environment. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is based on empirical process control theory. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is like traditional processes but with self-organization to replace Project Managers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each component of Scrum serves a specific purpose, and is essential to Scrum's success and your usage of Scrum to develop complex products. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a framework for developing and maintaining complex products.", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "0.10", Description = " How is management external to the Scrum team involved in the Daily Scrum? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team self-manages and is the only management required at the Daily Scrum. All others cannot participate. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner represents their opinions. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Management gives an update at the start of each Daily Scrum. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master speaks on their behalf. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "0.11", Description = "Which of the following are true about the length of the Sprint? Choose all that apply ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The length of the Sprint should be proportional to the work that is done in between Sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All Sprints must be 1 month or less. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint length is determined during Sprint Planning, and should hold the time it will take to code the planned features in the upcoming Sprint, but does not include time for any testing. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It is best to have Sprints of consistent length throughout a development effort.", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint length is determined during Sprint Planning, and should be long enough to make sure the Development Team can deliver what is to be accomplished in the upcoming Sprint	 ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.80", Description = " What is the maximum length of a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Not so long that the risk is unacceptable to the Product Owner. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No more than one calendar month. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Not so long that other business events can't be readily synchronized with the development work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "All of these answers are correct. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.79", Description = " The Scrum Master should NOT allow the Product Owner to go to the Sprint Planning meeting WITHOUT having already devised the Sprint Goal. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.78", Description = " Which does a self-organizing Development Team choose? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Stakeholders for the Sprint Review ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When to release, based on its progress ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How to best accomplish its work ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint length ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Product Backlog ordering ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.77", Description = " Which of the following is true about Scrum? Choose all that apply. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is like traditional processes but with self-organization to replace Project Managers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a methodology, where you can pick and choose which parts of Scrum you think Will work for your environment. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each component of Scrum serves a specific purpose, and is essential to Scrum's success and your usage of Scrum to develop complex products. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is a framework for developing and maintaining complex products. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum is based on empirical process control theory. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.76", Description = " What happens if the Development Team cannot complete its work by the end of a time-box? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box is adjusted permanently to reflect reality. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box holds and the Development Team continuously learns what is actually possible to do within a time-box. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The time-box is extended temporarily. Lessons are taken to ensure it doesn't happen again. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum should be abandoned. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.75", Description = " The Product Backlog is ordered by: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Safer items at the top to riskier items at the bottom. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Small items at the top to large items at the bottom. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Items are randomly arranged. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whatever is deemed most appropriate by the Product Owner. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Least valuable items at the top to most valuable at the bottom. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.74", Description = " During a Sprint Retrospective, for what is the Scrum Master responsible? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prioritizing the resulting action items. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Participating as a Scrum team member and facilitating as requested or needed. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Acting as a scribe to capture the Development Team's answers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Summarizing and reporting the discussions to management. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.73", Description = " Who has the final say on the order of the Product Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The CEO ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.72", Description = " Development Team members step up to own a Sprint Backlog item: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever a team member can accommodate more work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint planning meeting. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never. Al Sprint Backlog Items are \"owned\" by the entire Development Team, even though each one may be done by an individual Development ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team member. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Daily Scrum. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.71", Description = " A Scrum Master is introducing Scrum to a new Development Team. The Development Team has decided that a retrospective is unnecessay. What action should the Scrum Master take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Consult with the Product Owner to see how he/she feels about the situation. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Comply with the decision of the self-organizing team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Begin facilitating productive and useful retrospectives. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Call a meeting between the Development Team and senior management. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.70", Description = " Which three (3) questions are answered by all Development Team members at the Daily Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How is the Sprint proceeding? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What work did I do yesterday to help the team achieve its goal? ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Why were you late? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What work am I going to do today to help the team achieve its goal? ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How many hours did I spend on the project yesterday? ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What impediments are in my way or in the way of the team? ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.69", Description = " A Sprint Retrospective should be held: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of the last Sprint in a project or a release. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of each Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the beginning of each Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Only when the Scrum Team determines it needs one. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.67", Description = " What does it mean for a Development Team to be cross-functional? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is a virtual team drawing from separate teams of business analysts, architects, developers and testers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team includes not only developers but also business analysts, architects, developers and testers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team includes cross-skilled individuals who are able to contribute to do what is necessary to deliver an increment of software. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Developers on the Development Team work closely with business analysts, architects, developers and testers who are not on the team. ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "2.66", Description = " When is the Sprint Backlog created? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the beginning of the project ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint Planning meeting ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to the Sprint Planning meeting ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.65", Description = " During a Sprint, when is new work or further decomposition of work added to the Sprint Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As soon as possible after they are identified. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Scrum Master has time to enter them. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner identifies new work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Daily Scrum after the Development Team approves them. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.64", Description = " During a Sprint Retrospective, for what is the Product Owner responsible? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Summarizing and reporting the discussions to the stakeholders that he/she represents in the Scrum Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "He/She doesn't need to be there. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Participating as a Scrum Team member. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Capturing requirements for the Product Backlog. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.63", Description = " What is included in the Sprint Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "User Stories ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Use Cases ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tests ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tasks ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Any of the above (or others) which are a decomposition of the selected Product Backlog items ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.62", Description = " If quality assurance work does not occur as part of the development work within a Sprint, which benefits are lost? Choose all that apply. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The project manager cannot effectively update the plan. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The indication of progress on the Product Backlog is not transparent. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The increment is probably not releasable. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Future Sprints Will probably be interrupted with bugs that are being found. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.61", Description = " Every Scrum Team must have a Product Owner and Scrum Master. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True. Each must be 100% dedicated to the Scrum Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True. Outcomes are affected by their participation and availability. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.60", Description = " The only person who can abnormally terminate a Sprint is? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Stakeholders ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team or its members ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.59", Description = " If burndown charts are used to visualize progress, what do they track? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Individual worker productivity ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Accumulated business value delivered to the customer ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Accumulated cost ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Work remaining across time ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.58", Description = " Which answer best describes the topics covered in Sprint Planning? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What went wrong in the last Sprint and what to do differently this Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What to do and who Will do it. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Who is on the team and what team member roles Will be. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How conditions have changed and how the Product Backlog should evolve. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "What can be done and how to do it. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.57", Description = " Who must do all the work to make sure Product Backlog items conform to the Definition of \"Done\"? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "QA Specialists ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Team ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.56", Description = " How many hours per day should a person on a Scrum Team work? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "However many hours are needed to get the work done. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "14 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At a sustainable pace, usually 7-8 hours per day. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An \"ideal day\" measuring only when he or she is productive. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.55", Description = " Why should the Product Owner be present at the Daily Scrum? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To participate as a Scrum Team member. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To represent the stakeholders' point of view. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To hear about impediments in functionality. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "He/She doesn't need to be there. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.54", Description = " Which of the following is NOT a timeboxed event in Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Retrospective ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Daily Scrum ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release Testing ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint 0 ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release Retrospective ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Testing ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.53", Description = " Choose three responsibilities of a self-organizing Development Team. Choose three answers. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Reorder the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Track velocity. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Report daily progress to stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Pull Product Backlog items for the Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Do the work planned in the Sprint Backlog. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Set the time for the Daily Scrum. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.52", Description = " When multiple Scrum teams are working on the same project, they should make sure that each team has different Sprint start dates. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.51", Description = " Which of the following might the Scrum Team discuss during a Sprint Retrospective? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Methods of communication. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "ts Definition of \"done.\" ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The way the Scrum Team does Sprint Planning. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Skills needed to improve the Development Team's ability to deliver. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al of the above. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.50", Description = " Which technique is the LEAST productive way for the Scrum Master to ensure that the Development Team communicates effectively with the Product Owner? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Act as a go-between for them. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Teach the Team to talk in terms of business needs and objectives. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Teach the Product Owner about the technologies employed during the ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitor communications between them. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.49", Description = " Scrum Master is a \"management\" position? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.48", Description = " When may a Development Team change its engineering practices? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever needed ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During Sprint Planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "During the Sprint Retrospective ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to starting a new Sprint ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prior to starting a new project ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.47", Description = " When a Development Team determines that it has over-committed itself for a Sprint, who has to be present when reviewing and adjusting the Sprint work selected? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master, project manager and Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and the Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner and all stakeholders ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.46", Description = " As Scrum Teams mature, it is expected that the following decision is likely to be taken: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Retrospectives Will grow to be longer than 4 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no need for a time-boxed Sprint, since time-boxes are only for new Scrum Teams. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Scrum Master is no longer needed since they are a mature team now. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "They Will improve their definition of \"Done\" to include more stringent criteria. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Reviews Will no longer be needed. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.45", Description = " The purpose of a Sprint is to produce a done increment of working product. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.44", Description = " What are two responsibilities of testers in a Development Team? Choose two answers. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Verifying the work of programmers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Finding bugs ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Scrum has no \"tester\" role ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Tracking quality metrics ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Everyone in the Development Team is responsible for quality ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.43", Description = " Who determines how work is performed during the Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Arch itects ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Development Team managers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Subject matter experts ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.42", Description = " Which of the following are true about the Product Owner role? (Choose 3 answers) ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner role can be played by a committee or a team of people. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner can be influenced by a committee. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Multiple people can share the Product Owner role on a Scrum Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is accountable for ordering the Product Backlog. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is one person. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.41", Description = " Scrum is a methodology that tells in detail how to build software incrementally. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.40", Description = " How often should Development Team membership change? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just as it would on any development team, with no special allowance for ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "changes in productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As needed, while taking into account a short term reduction in productivity. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Never, because it reduces productivity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Every Sprint to promote shared learning. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.39", Description = " Items on the Product Backlog tend to be: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Larger than the items in the Sprint Backlog. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "t depends. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The same size as the items in the Sprint Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Smaller than the items in the Sprint Backlog. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.38", Description = " When many Development Teams are working on a single product, what best describes the definition of \"Done?\" ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each Development Team uses its own but must make their definition clear to all other Teams so the differences are known. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al Development Teams must have a definition of \"Done\" that makes their combined work potentially releasable. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Each Development Team defines and uses its own. The differences are discussed and reconciled during a hardening Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "It depends. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.36", Description = " How much of the Sprint Backlog must be defined during the Sprint Planning meeting? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just enough to understand design and architectural implications. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Enough so the Development Team can create its best forecast of what it can do, and to start the first several days of the Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Al of the potential work. The Sprint Planning meeting isn't over until 100% of the work is identified and estimated. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Just enough tasks for the Scrum Master to be confident in the Development Team's understanding of the Sprint. ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "2.35", Description = " Which is NOT a Development Team responsibility? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Optimizing the work required to meet the Sprint Goal at least daily ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Selecting the Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Resolving internal team conflicts ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Planning how to meet a Sprint Goal ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitoring productivity ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.34", Description = " Which of these may a Development Team deliver at the end of a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An increment of working software that is \"done.\" ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A single document, if that is what the Scrum Master asked for. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Failing unit tests, to identify acceptance tests for the next Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An increment of software with minor known bugs in it. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.33", Description = " Who is on the Scrum Team? Choose all that apply. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Project Manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "None of the above ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.32", Description = " Which of the following is true about the Scrum Master role? Choose all that apply. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the Sprint Review, the Scrum Master identifies what has been \"done\" and what has not been \"done\". ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master is responsible for updating the Sprint Burndown. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master helps those outside the team interact with the Scrum Team. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master teaches the Development Team to keep the Scrum meetings to their timebox. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master assigns tasks to Development Team members when they need work. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.31", Description = " Which statement best describes a Product Owner's responsibility? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Keeping stakeholders at bay. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Managing the project and ensuring that the work meets the commitments to ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "the stakeholders. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Optimizing the value of the work the Development Team does. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Directing the Development Team. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.30", Description = " The Development Team should not be interrupted during the Sprint. The Sprint Goal should remain intact. These are conditions that foster creativity, quality and productivity. Based on this, which of the following is FALSE? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As a decomposition of the selected Product Backlog Items, the Sprint Backlog changes and may grow as the work emerges. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner can help clarify or optimize the Sprint when asked by the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Backlog and its contents are fully formulated in the Sprint Planning meeting and do not change during the Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team may work with the Product Owner to remove or add work if it finds it has more or less capacity than it expected. ", IsCorrect = false, Value = false, Question = question });


            question = new Question { Name = "2.29", Description = " Which three (3) activities Will a Product Owner likely engage in during a Sprint? Choose 3 answers. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Answer questions from the Development Team about items in the current Sprint. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Run the Daily Scrum. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Provide feedback. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Prioritize the Development Team's tasks. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Work with the stakeholders. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Update the Sprint burndown chart. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.28", Description = " The Product Owner must ship each Sprint increment. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Choose one answer. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "To make sure the Development Team is done every Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When it makes sense. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Whenever the product is free of defects. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Without exception. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.27", Description = " The time-box for the Sprint Review is? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of every Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours for a 4 week Sprint. Usually shorter for shorter Sprints. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "However long is needed. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "15 minutes. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.26", Description = " When many Scrum Teams are working on the same product, should all of their increments be integrated every Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No, that is far too hard and must be done in a hardening Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "No, each Scrum Team stands alone. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Yes, but only for Scrum Teams whose work has dependencies. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Yes, otherwise the Product Owners (and stakeholders) may not be able to accurately inspect what is done. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.25", Description = " Why does a Development Team need a Sprint Goal? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is more focused with a common yet specific goal. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Goals are not valuable. Everything is known from the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Sprint Goal ensures that all of the Product Backlog items selected for the Sprint are implemented. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A Sprint Goal only gives purpose to Sprint 0. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.24", Description = " A Scrum Master is working with a Development Team that has members in different physical locations. The Development Team meets in a variety of meeting rooms and has much to do logistically (for example, set up conference calls) before the Daily Scrum. What action should the Scrum Master take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Allow the Development Team to self-manage and determine for itself what to do. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ask the Development Team members to alternate who is responsible for meeting setup. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inform management and ask them to solve it. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Set up the meeting and tell the Development Team that is how it Will be done. ", IsCorrect = true, Value = false, Question = question });


            question = new Question { Name = "2.23", Description = " The maximum length of the Sprint Review (its timebox) is: ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "As long as needed. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "1 day. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "2 hours. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours for a monthly Sprint. For shorter Sprints it is usually shorter. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "4 hours and longer as needed. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.22", Description = " Who is responsible for tracking the remaining work of the Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team in consultation with the Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Project Manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.21", Description = " What are three benefits of self-organization? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased commitment ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased rule compliance ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased creativity ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased predictability ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Increased self-accountability ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.20", Description = " An abnormal termination of a Sprint is called when? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When it is clear at the end of a Sprint that everything won't be finished. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When Sales has an important opportunity. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner determines that it makes no sense to finish it. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Team feels that the work is too hard. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.19", Description = " Which phrase best describes a Product Owner? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Go-between between development team and customers ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Value optimizer ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team manager ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Requirements engineer ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.18", Description = " A Sprint Review is the only time that the stakeholders and the Scrum Team can come together. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.17", Description = " Which output from Sprint Planning provides the Development Team with a target and overarching direction forthe Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The release plan ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Goal ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Sprint Backlog ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Review minutes ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.16", Description = " While under development, the environment in which a product Will be used changes and emerges. What is the effect on the Product Backlog? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt is archived and a new Product Backlog is created to take its place. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The requirements specification document, describing the Product Backlog items, must be updated to ensure stability. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "There is no effect, because it has to stay the same until the end of the project. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt evolves to reflect what the product needs to be most valuable. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.15", Description = " For the purpose of transparency, when does Scrum say a new increment of working software must be available? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Before the release Sprint. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Every 3 Sprints. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "After the acceptance testing phase. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "When the Product Owner asks to create one. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "At the end of every Sprint. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.14", Description = " The Product Owner makes sure the team selects enough from the Product Backlog for a Sprint to satisfy the stakeholders. ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.13", Description = " Which are NOT appropriate topics for discussion in a Sprint Retrospective? (Choose 2 answers) ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Team relations ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Definition of \"Done\" ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "How the team does its work ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Backlog for the next Sprint ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The value of work currently represented in the Product Backlog ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.12", Description = " During the Sprint, the Scrum Master's role is to: ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Escalate team conflicts to functional line managers. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Ensure the Product Owner attends all Scrum events. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Remove impediments. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Monitor the progress of the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Assign tasks with the Scrum team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Facilitate inspection and adaption opportunities as requested or needed. ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.11", Description = " Which of the following best describes an increment of working software? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Additional features in a useable state that complement those delivered in previous iterations. ", IsCorrect = true, Value = false, Question = question });

            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "An automated test suite to verify functionality delivered in previous iterations. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "UML diagrams that describe how to deliver functionality in future iterations. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A decomposition of all Product Backlog items into tasks for future Sprint Backlog lists. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A new user interface design for functionality delivered in previous iterations. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.10", Description = " Which two (2) things does the Development Team NOT do during the first Sprint? Choose 2 answers. ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Develop and deliver at least one piece of functionality. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Nail down the complete architecture and infrastructure. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Develop a plan for the rest of the project. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Deliver an increment of potentially shippable functionality. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.9", Description = " The Product Owner remains distant. He/she has handed over the required Product Backlog for the Sprint but is not collaborating with the Development Team during the Sprint. What are valuable actions for a Scrum Master? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Coach the Product Owner in the values of Scrum and incremental delivery. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Stop the Sprint, send the Product Owner to a course and restart. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Inform the Product Owner's functional manager. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Bring up the problem in the Sprint Retrospective. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Nominate a proxy Product Owner. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.8", Description = " Which of the following are feedback loops in Scrum? ", Type = QuestionType.MultipleSelection, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Choose all that apply. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Review ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Release planning ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Daily Scrum ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Sprint Retrospective ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.7", Description = " A new developer is having continuing conflicts with existing Development Team members and creating a hostile environment. If necessary, who is responsible for removing the team member? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is responsible, because he/she controls the return on investment (ROI). ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The hiring manager is responsible, because he/she hired the developer. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master is responsible, because he/she removes Impediments. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team is responsible, and may need help from the Scrum Master ", IsCorrect = true, Value = false, Question = question });

            question = new Question { Name = "2.6", Description = " Who creates a Product Backlog item's estimate? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner with input from the Development Team. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The most senior people in the organization, including architects and subject matter experts. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Scrum Master. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team, alone. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Development Team after clarifying requirements with the Product Owner. ", IsCorrect = true, Value = false, Question = question });


            question = new Question { Name = "2.5", Description = " Scrum does not have a role called \"Project Manager.\" ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "True ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "False ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.4", Description = " The Scrum Master observes the Product Owner struggling with ordering the Product Backlog. What would you consider an appropriate action for the Scrum Master to take? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Encourage the Product Owner to work with the Development Team to see which items technically are fastest to implement. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Suggest that the Development Team does the ordering to be sure that it is a feasible ordering of work. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Suggest the Product Owner extend the Sprint, so he can have more time to order the Product Backlog. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Offer the Product Owner help in ordering the Product Backlog from an understanding that the goal is to maximize value. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Present the Product Owner with an ordered Product Backlog to use. ", IsCorrect = false, Value = false, Question = question });

            question = new Question { Name = "2.3", Description = " When can a Development Team cancel a Sprint? ", Type = QuestionType.MultipleOption, Test = test };
            context.Questions.AddOrUpdate(q => q.Name, question);
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "A technical dependency cannot be resolved. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Functional expectations are not well understood. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The forecast for the Sprint becomes un-achievable. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "lt can't. Only Product Owners can cancel Sprints. ", IsCorrect = true, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "The Product Owner is absent too often. ", IsCorrect = false, Value = false, Question = question });
            context.Answers.AddOrUpdate(q => q.Name, new Answer { Name = "Answers A or D. ", IsCorrect = false, Value = false, Question = question });

        }
    }
}
