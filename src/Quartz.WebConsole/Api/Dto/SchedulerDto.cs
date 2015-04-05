﻿namespace Quartz.Web.Api.Dto
{
    public class SchedulerDto
    {
        public SchedulerDto(IScheduler scheduler)
        {
            Name = scheduler.SchedulerName;
            Status = SchedulerHeaderDto.TranslateStatus(scheduler);

            var metaData = scheduler.GetMetaData();
            ThreadPool = new SchedulerThreadPoolDto(metaData);
            JobStore = new SchedulerJobStoreDto(metaData);
            Statistics = new SchedulerStatisticsDto(metaData);
        }

        public string Name { get; private set; }
        public SchedulerStatus Status { get; private set; }

        public SchedulerThreadPoolDto ThreadPool { get; private set; }
        public SchedulerJobStoreDto JobStore { get; private set; }
        public SchedulerStatisticsDto Statistics { get; private set; }
    }
}