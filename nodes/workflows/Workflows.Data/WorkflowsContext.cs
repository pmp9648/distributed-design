using Distributed.Core.Data;
using Microsoft.EntityFrameworkCore;
using Workflows.Contracts;
using Workflows.Entities;

namespace Workflows.Data;
public class WorkflowsContext : EntityContext<WorkflowsContext>
{
    public WorkflowsContext(DbContextOptions<WorkflowsContext> options) : base(options) { }

    public DbSet<Package> Packages => Set<Package>();
    public DbSet<Process> Processes => Set<Process>();
    public DbSet<ProcessTemplate> ProcessTemplates => Set<ProcessTemplate>();
    public DbSet<Workflow> Workflows => Set<Workflow>();
    public DbSet<WorkflowTemplate> WorkflowTemplates => Set<WorkflowTemplate>();
}