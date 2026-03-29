import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { JobService, Job } from '../services/job.service';

@Component({
  selector: 'app-job-list',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterLink],
  templateUrl: './job-list.component.html',
  styleUrl: './job-list.component.css'
})
export class JobListComponent implements OnInit {
  jobs: Job[] = [];
  filteredJobs: Job[] = [];
  categories: string[] = [];

  keyword = '';
  location = '';
  selectedCategory = 'All';

  constructor(private jobService: JobService) {}

  ngOnInit(): void {
    this.jobs = this.jobService.getJobs();
    this.filteredJobs = this.jobs;
    this.categories = this.jobService.getCategories();
  }

  search(): void {
    this.filteredJobs = this.jobService.searchJobs(
      this.keyword,
      this.location,
      this.selectedCategory
    );
  }

  clearFilters(): void {
    this.keyword = '';
    this.location = '';
    this.selectedCategory = 'All';
    this.filteredJobs = this.jobs;
  }
}
