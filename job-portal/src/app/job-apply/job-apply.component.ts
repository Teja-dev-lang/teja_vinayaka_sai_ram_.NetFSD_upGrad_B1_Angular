import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { JobService, Job } from '../services/job.service';

@Component({
  selector: 'app-job-apply',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterLink],
  templateUrl: './job-apply.component.html',
  styleUrl: './job-apply.component.css'
})
export class JobApplyComponent implements OnInit {
  job: Job | undefined;
  submitted = false;
  alreadyApplied = false;

  name = '';
  email = '';
  phone = '';
  resume = '';
  coverLetter = '';

  errors: { [key: string]: string } = {};

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private jobService: JobService
  ) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.job = this.jobService.getJobById(id);
  }

  validate(): boolean {
    this.errors = {};
    if (!this.name.trim())  this.errors['name'] = 'Full name is required.';
    if (!this.email.trim()) {
      this.errors['email'] = 'Email address is required.';
    } else if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(this.email)) {
      this.errors['email'] = 'Enter a valid email address.';
    }
    if (!this.phone.trim()) {
      this.errors['phone'] = 'Phone number is required.';
    } else if (!/^\+?[\d][\d\s\-]{6,14}[\d]$/.test(this.phone.trim())) {
      this.errors['phone'] = 'Enter a valid phone number.';
    }
    if (!this.resume.trim()) this.errors['resume'] = 'Resume link or text is required.';
    return Object.keys(this.errors).length === 0;
  }

  submitApplication(): void {
    if (!this.job) return;
    if (!this.validate()) return;

    if (this.jobService.hasApplied(this.job.id, this.email)) {
      this.alreadyApplied = true;
      return;
    }

    this.jobService.submitApplication({
      jobId: this.job.id,
      jobTitle: this.job.title,
      company: this.job.company,
      name: this.name.trim(),
      email: this.email.trim(),
      phone: this.phone.trim(),
      resume: this.resume.trim(),
      coverLetter: this.coverLetter.trim(),
      appliedDate: new Date().toISOString().split('T')[0]
    });

    this.submitted = true;
  }
}
