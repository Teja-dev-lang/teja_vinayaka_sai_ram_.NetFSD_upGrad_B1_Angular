import { Injectable } from '@angular/core';

export interface Job {
  id: number;
  title: string;
  company: string;
  location: string;
  type: string;
  category: string;
  salary: string;
  description: string;
  requirements: string[];
  postedDate: string;
}

export interface Application {
  jobId: number;
  jobTitle: string;
  company: string;
  name: string;
  email: string;
  phone: string;
  resume: string;
  coverLetter: string;
  appliedDate: string;
}

@Injectable({
  providedIn: 'root'
})
export class JobService {
  private jobs: Job[] = [
    {
      id: 1,
      title: 'Frontend Angular Developer',
      company: 'TechCorp Solutions',
      location: 'Hyderabad, India',
      type: 'Full-Time',
      category: 'Software Development',
      salary: '₹8,00,000 - ₹14,00,000 / year',
      description: 'We are looking for a skilled Angular developer to build and maintain high-quality web applications. You will work closely with the product and design teams to deliver a seamless user experience.',
      requirements: ['3+ years of Angular experience', 'Strong TypeScript skills', 'Experience with RxJS', 'REST API integration', 'Git version control'],
      postedDate: '2026-03-20'
    },
    {
      id: 2,
      title: '.NET Full Stack Developer',
      company: 'Infosys',
      location: 'Bangalore, India',
      type: 'Full-Time',
      category: 'Software Development',
      salary: '₹10,00,000 - ₹18,00,000 / year',
      description: 'Join our team to develop enterprise-grade applications using .NET Core and Angular. You will be part of an agile team working on large-scale projects for global clients.',
      requirements: ['.NET Core / ASP.NET', 'Angular or React', 'SQL Server / Entity Framework', 'REST API & Microservices', 'Agile / Scrum methodology'],
      postedDate: '2026-03-22'
    },
    {
      id: 3,
      title: 'Junior Software Engineer',
      company: 'StartupHub',
      location: 'Pune, India',
      type: 'Full-Time',
      category: 'Software Development',
      salary: '₹4,00,000 - ₹7,00,000 / year',
      description: 'Great opportunity for fresh graduates and early-career developers. You will learn and contribute to building modern web applications in a fast-paced startup environment.',
      requirements: ['0–2 years experience', 'HTML, CSS, JavaScript basics', 'Knowledge of any framework (Angular/React)', 'Problem-solving skills', 'Eagerness to learn'],
      postedDate: '2026-03-24'
    },
    {
      id: 4,
      title: 'SQL Database Administrator',
      company: 'DataVault Inc.',
      location: 'Chennai, India',
      type: 'Full-Time',
      category: 'Database',
      salary: '₹7,00,000 - ₹12,00,000 / year',
      description: 'Responsible for database administration, performance tuning, backup strategies, and ensuring data integrity across multiple production environments.',
      requirements: ['SQL Server / MySQL / PostgreSQL', 'Query optimization', 'Backup & recovery procedures', 'Database design & normalization', '3+ years DBA experience'],
      postedDate: '2026-03-18'
    },
    {
      id: 5,
      title: 'React UI Developer',
      company: 'WebWave Agency',
      location: 'Mumbai, India',
      type: 'Contract',
      category: 'Frontend',
      salary: '₹6,00,000 - ₹11,00,000 / year',
      description: 'We need a creative UI developer to build beautiful, responsive interfaces using React. The role involves close collaboration with designers and backend engineers.',
      requirements: ['React.js 3+ years', 'CSS3 / SCSS / Tailwind', 'Figma / Adobe XD', 'RESTful API consumption', 'Cross-browser compatibility'],
      postedDate: '2026-03-25'
    },
    {
      id: 6,
      title: 'C# Backend Developer',
      company: 'CloudSystems Ltd.',
      location: 'Remote',
      type: 'Remote',
      category: 'Backend',
      salary: '₹9,00,000 - ₹15,00,000 / year',
      description: 'Build scalable backend services and APIs using C# and .NET. You will design microservices, integrate with cloud platforms (Azure/AWS), and mentor junior developers.',
      requirements: ['C# / .NET Core', 'Microservices architecture', 'Azure or AWS', 'Docker & Kubernetes basics', 'SOLID principles'],
      postedDate: '2026-03-26'
    },
    {
      id: 7,
      title: 'DevOps Engineer',
      company: 'Wipro Technologies',
      location: 'Hyderabad, India',
      type: 'Full-Time',
      category: 'DevOps',
      salary: '₹12,00,000 - ₹20,00,000 / year',
      description: 'Drive CI/CD pipelines, infrastructure as code, and cloud management. Work with cross-functional teams to improve deployment frequency and system reliability.',
      requirements: ['CI/CD (Jenkins/GitHub Actions)', 'Docker & Kubernetes', 'Terraform / Ansible', 'AWS / Azure / GCP', 'Linux administration'],
      postedDate: '2026-03-15'
    },
    {
      id: 8,
      title: 'QA Automation Engineer',
      company: 'TestPro Solutions',
      location: 'Noida, India',
      type: 'Full-Time',
      category: 'Quality Assurance',
      salary: '₹5,50,000 - ₹9,00,000 / year',
      description: 'Design, develop, and execute automated test suites for web and API applications. Collaborate with developers to integrate tests into the CI/CD pipeline.',
      requirements: ['Selenium / Cypress', 'API testing (Postman/RestAssured)', 'Java or Python for automation', 'TestNG / JUnit', 'BDD / Gherkin'],
      postedDate: '2026-03-21'
    }
  ];

  private applications: Application[] = [];

  getJobs(): Job[] {
    return this.jobs;
  }

  getJobById(id: number): Job | undefined {
    return this.jobs.find(j => j.id === id);
  }

  searchJobs(keyword: string, location: string, category: string): Job[] {
    return this.jobs.filter(job => {
      const matchKeyword = !keyword ||
        job.title.toLowerCase().includes(keyword.toLowerCase()) ||
        job.company.toLowerCase().includes(keyword.toLowerCase()) ||
        job.description.toLowerCase().includes(keyword.toLowerCase());
      const matchLocation = !location ||
        job.location.toLowerCase().includes(location.toLowerCase());
      const matchCategory = !category || category === 'All' ||
        job.category === category;
      return matchKeyword && matchLocation && matchCategory;
    });
  }

  submitApplication(application: Application): void {
    this.applications.push(application);
  }

  getApplications(): Application[] {
    return this.applications;
  }

  hasApplied(jobId: number, email: string): boolean {
    return this.applications.some(a => a.jobId === jobId && a.email === email);
  }

  getCategories(): string[] {
    return ['All', ...Array.from(new Set(this.jobs.map(j => j.category)))];
  }
}
