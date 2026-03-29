/**
 * JobFinder – Automated Job Search Portal
 * app.js
 *
 * Features:
 *  - Debounced live / auto-search (search as you type)
 *  - Multi-filter: job type, experience level, salary range, date posted
 *  - Sort: relevance, date, salary
 *  - Pagination (6 jobs per page)
 *  - Save / unsave jobs (persisted to localStorage)
 *  - Apply to jobs with status tracking (persisted to localStorage)
 *  - Job detail modal
 *  - Toast notifications
 */

"use strict";

/* ================================================================
   1.  JOB DATA  (mock dataset – replace with API calls as needed)
   ================================================================ */

const JOB_DATA = [
    {
        id: 1,
        title: "Frontend Developer",
        company: "TechNova Solutions",
        logo: "💻",
        location: "Hyderabad",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 8,
        salaryMax: 14,
        postedDaysAgo: 1,
        description: "Build responsive web applications using Angular and React. Collaborate with designers and backend engineers to deliver high-quality UI.",
        requirements: ["3+ years of JavaScript/TypeScript", "Strong Angular or React skills", "REST API integration", "Git version control"],
        skills: ["Angular", "React", "TypeScript", "CSS3", "REST APIs"],
    },
    {
        id: 2,
        title: "Backend Developer (.NET)",
        company: "Infosys",
        logo: "🖥️",
        location: "Pune",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 10,
        salaryMax: 18,
        postedDaysAgo: 2,
        description: "Design and maintain RESTful APIs using ASP.NET Core. Work with SQL Server databases and microservices architecture.",
        requirements: ["3+ years of C# / ASP.NET Core", "Entity Framework Core", "SQL Server", "Understanding of microservices"],
        skills: ["C#", "ASP.NET Core", "SQL Server", "EF Core", "Docker"],
    },
    {
        id: 3,
        title: "Full-Stack Developer",
        company: "Wipro",
        logo: "🔷",
        location: "Bangalore",
        type: "Full-Time",
        experience: "Senior Level",
        salaryMin: 16,
        salaryMax: 28,
        postedDaysAgo: 3,
        description: "Join our digital engineering team to build cloud-native full-stack solutions using Angular + .NET Core.",
        requirements: ["5+ years of full-stack development", "Angular & ASP.NET Core", "Azure / AWS cloud experience", "Agile/Scrum methodology"],
        skills: ["Angular", "ASP.NET Core", "Azure", "SQL Server", "Docker"],
    },
    {
        id: 4,
        title: "Software Engineer Intern",
        company: "upGrad",
        logo: "🎓",
        location: "Mumbai",
        type: "Internship",
        experience: "Entry Level",
        salaryMin: 1,
        salaryMax: 3,
        postedDaysAgo: 0,
        description: "Work alongside experienced engineers on real-world EdTech products. Learn modern web development best practices.",
        requirements: ["Knowledge of HTML/CSS/JavaScript", "Basic understanding of any backend language", "Eagerness to learn"],
        skills: ["JavaScript", "HTML", "CSS", "Git"],
    },
    {
        id: 5,
        title: "DevOps Engineer",
        company: "Amazon",
        logo: "☁️",
        location: "Hyderabad",
        type: "Full-Time",
        experience: "Senior Level",
        salaryMin: 20,
        salaryMax: 35,
        postedDaysAgo: 4,
        description: "Manage CI/CD pipelines, containerize workloads using Docker/Kubernetes, and maintain AWS infrastructure at scale.",
        requirements: ["5+ years DevOps experience", "Docker & Kubernetes", "AWS / Azure", "Terraform / Ansible"],
        skills: ["DevOps", "Docker", "Kubernetes", "AWS", "Terraform"],
    },
    {
        id: 6,
        title: "Angular Developer",
        company: "Cognizant",
        logo: "🅲",
        location: "Chennai",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 9,
        salaryMax: 15,
        postedDaysAgo: 5,
        description: "Develop and maintain enterprise Angular applications for global banking clients. Implement reusable component libraries.",
        requirements: ["3+ years of Angular (v12+)", "TypeScript expertise", "RxJS & NgRx state management", "Unit testing with Jasmine/Karma"],
        skills: ["Angular", "TypeScript", "RxJS", "NgRx", "Jasmine"],
    },
    {
        id: 7,
        title: "Data Analyst",
        company: "Deloitte",
        logo: "📊",
        location: "Bangalore",
        type: "Full-Time",
        experience: "Entry Level",
        salaryMin: 5,
        salaryMax: 10,
        postedDaysAgo: 6,
        description: "Analyse large datasets using SQL and Python, build dashboards in Power BI, and present insights to stakeholders.",
        requirements: ["SQL proficiency", "Python / Pandas", "Power BI or Tableau", "Good communication skills"],
        skills: ["SQL", "Python", "Power BI", "Excel", "Data Visualisation"],
    },
    {
        id: 8,
        title: "Remote React Developer",
        company: "StartupXYZ",
        logo: "⚛️",
        location: "Remote",
        type: "Remote",
        experience: "Mid Level",
        salaryMin: 12,
        salaryMax: 20,
        postedDaysAgo: 2,
        description: "100% remote position. Build fast, accessible React SPAs for a fast-growing SaaS startup. Flexible hours.",
        requirements: ["3+ years React", "Redux / React Query", "REST / GraphQL APIs", "Self-motivated remote worker"],
        skills: ["React", "Redux", "GraphQL", "TypeScript", "Jest"],
    },
    {
        id: 9,
        title: "QA Automation Engineer",
        company: "HCL Technologies",
        logo: "🧪",
        location: "Noida",
        type: "Contract",
        experience: "Mid Level",
        salaryMin: 7,
        salaryMax: 13,
        postedDaysAgo: 8,
        description: "Design and execute automated test suites using Selenium and Playwright for web and mobile applications.",
        requirements: ["Selenium / Playwright", "Java or Python scripting", "CI/CD integration", "Agile testing experience"],
        skills: ["Selenium", "Playwright", "Java", "Python", "CI/CD"],
    },
    {
        id: 10,
        title: "Cloud Solutions Architect",
        company: "Microsoft",
        logo: "🪟",
        location: "Hyderabad",
        type: "Full-Time",
        experience: "Lead / Manager",
        salaryMin: 30,
        salaryMax: 50,
        postedDaysAgo: 1,
        description: "Design cloud architectures on Azure for enterprise customers. Lead technical workshops and proof-of-concept engagements.",
        requirements: ["8+ years IT/cloud experience", "Azure certifications", "Architectural design patterns", "Customer-facing skills"],
        skills: ["Azure", "Cloud Architecture", "Microservices", "Security", "Terraform"],
    },
    {
        id: 11,
        title: "Java Backend Developer",
        company: "TCS",
        logo: "☕",
        location: "Pune",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 8,
        salaryMax: 16,
        postedDaysAgo: 10,
        description: "Build microservices using Spring Boot, deploy on AWS, and work with cross-functional Agile teams.",
        requirements: ["3+ years Java / Spring Boot", "Microservices design", "AWS basics", "SQL / NoSQL databases"],
        skills: ["Java", "Spring Boot", "AWS", "MySQL", "Docker"],
    },
    {
        id: 12,
        title: "UI/UX Designer",
        company: "Flipkart",
        logo: "🎨",
        location: "Bangalore",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 10,
        salaryMax: 18,
        postedDaysAgo: 3,
        description: "Design intuitive user experiences for millions of shoppers. Conduct user research, create wireframes and high-fidelity prototypes.",
        requirements: ["Figma / Sketch expertise", "Strong UX research skills", "Design systems experience", "Basic HTML/CSS helpful"],
        skills: ["Figma", "UX Research", "Prototyping", "Design Systems", "Adobe XD"],
    },
    {
        id: 13,
        title: "Part-Time Content Writer (Tech)",
        company: "GeeksForGeeks",
        logo: "✍️",
        location: "Remote",
        type: "Part-Time",
        experience: "Entry Level",
        salaryMin: 2,
        salaryMax: 5,
        postedDaysAgo: 0,
        description: "Write technical tutorials, blog posts, and guides on web development, data structures, and algorithms.",
        requirements: ["Strong technical writing skills", "Knowledge of programming concepts", "Ability to explain complex topics simply"],
        skills: ["Technical Writing", "JavaScript", "Algorithms", "SEO Basics"],
    },
    {
        id: 14,
        title: "Engineering Manager",
        company: "Razorpay",
        logo: "💳",
        location: "Bangalore",
        type: "Full-Time",
        experience: "Lead / Manager",
        salaryMin: 35,
        salaryMax: 50,
        postedDaysAgo: 7,
        description: "Lead a team of 8–12 engineers building FinTech payment infrastructure. Drive technical direction and team growth.",
        requirements: ["5+ years engineering + 2+ years management", "FinTech or high-scale system experience", "Strong hiring and mentoring skills"],
        skills: ["Engineering Leadership", "System Design", "Agile", "Hiring", "FinTech"],
    },
    {
        id: 15,
        title: "SQL Database Administrator",
        company: "Oracle",
        logo: "🗄️",
        location: "Chennai",
        type: "Full-Time",
        experience: "Senior Level",
        salaryMin: 14,
        salaryMax: 22,
        postedDaysAgo: 12,
        description: "Manage Oracle and SQL Server databases, ensure high availability, disaster recovery, performance tuning, and security compliance.",
        requirements: ["5+ years DBA experience", "Oracle / SQL Server expertise", "Performance tuning", "Backup & recovery"],
        skills: ["Oracle DB", "SQL Server", "PL/SQL", "Performance Tuning", "Linux"],
    },
    {
        id: 16,
        title: "Mobile Developer (React Native)",
        company: "Swiggy",
        logo: "🍔",
        location: "Bangalore",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 14,
        salaryMax: 24,
        postedDaysAgo: 2,
        description: "Build and ship features for Swiggy's consumer app. Collaborate closely with Product and Design teams to delight customers.",
        requirements: ["3+ years React Native", "iOS & Android deployment", "Performance optimisation", "Redux / MobX"],
        skills: ["React Native", "JavaScript", "Redux", "iOS", "Android"],
    },
    {
        id: 17,
        title: "Cybersecurity Analyst",
        company: "IBM",
        logo: "🔐",
        location: "Hyderabad",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 12,
        salaryMax: 20,
        postedDaysAgo: 5,
        description: "Monitor, detect and respond to security incidents. Conduct vulnerability assessments and penetration testing.",
        requirements: ["CEH / CISSP certification preferred", "SIEM tools (Splunk, QRadar)", "Incident response", "Network security"],
        skills: ["Cybersecurity", "Splunk", "Penetration Testing", "Network Security", "SIEM"],
    },
    {
        id: 18,
        title: "Python Developer",
        company: "Zomato",
        logo: "🐍",
        location: "Gurgaon",
        type: "Full-Time",
        experience: "Mid Level",
        salaryMin: 10,
        salaryMax: 18,
        postedDaysAgo: 9,
        description: "Build Python-based microservices, data pipelines, and automation scripts for Zomato's platform engineering team.",
        requirements: ["3+ years Python", "Django / FastAPI", "Celery / Redis", "PostgreSQL / MongoDB"],
        skills: ["Python", "FastAPI", "Django", "PostgreSQL", "Redis"],
    },
    {
        id: 19,
        title: "Scrum Master",
        company: "Accenture",
        logo: "🏃",
        location: "Mumbai",
        type: "Contract",
        experience: "Senior Level",
        salaryMin: 15,
        salaryMax: 25,
        postedDaysAgo: 6,
        description: "Facilitate Agile ceremonies for multiple squads, remove impediments, and coach teams on Scrum best practices.",
        requirements: ["CSM or PSM certification", "4+ years as Scrum Master", "Large-scale Agile (SAFe / LeSS)", "Stakeholder management"],
        skills: ["Scrum", "SAFe", "Agile Coaching", "JIRA", "Facilitation"],
    },
    {
        id: 20,
        title: "Machine Learning Engineer",
        company: "Google India",
        logo: "🤖",
        location: "Hyderabad",
        type: "Full-Time",
        experience: "Senior Level",
        salaryMin: 28,
        salaryMax: 50,
        postedDaysAgo: 0,
        description: "Research, design and deploy ML models at scale. Collaborate with world-class teams on AI-first Google products.",
        requirements: ["PhD or 5+ years ML experience", "TensorFlow / PyTorch", "MLOps pipelines", "Strong math/stats foundation"],
        skills: ["Machine Learning", "Python", "TensorFlow", "PyTorch", "MLOps"],
    },
];

/* ================================================================
   2.  STATE
   ================================================================ */

const state = {
    keyword: "",
    location: "",
    jobTypes: ["Full-Time", "Part-Time", "Contract", "Internship", "Remote"],
    experienceLevels: ["Entry Level", "Mid Level", "Senior Level", "Lead / Manager"],
    salaryMin: 0,
    salaryMax: 50,
    datePosted: "any",   // "any" | "1" | "7" | "30"
    sort: "relevance",
    page: 1,
    pageSize: 6,
    autoSearch: true,
    savedIds: new Set(JSON.parse(localStorage.getItem("jf_saved") || "[]")),
    appliedIds: new Set(JSON.parse(localStorage.getItem("jf_applied") || "[]")),
    currentSection: "search",  // "search" | "saved" | "applied"
};

/* ================================================================
   3.  UTILITY FUNCTIONS
   ================================================================ */

/** Debounce: delay function call until user stops typing */
function debounce(fn, delay) {
    let timer;
    return function (...args) {
        clearTimeout(timer);
        timer = setTimeout(() => fn.apply(this, args), delay);
    };
}

function persistSaved() {
    localStorage.setItem("jf_saved", JSON.stringify([...state.savedIds]));
}

function persistApplied() {
    localStorage.setItem("jf_applied", JSON.stringify([...state.appliedIds]));
}

function showToast(message) {
    const toast = document.getElementById("toast");
    toast.textContent = message;
    toast.classList.add("show");
    setTimeout(() => toast.classList.remove("show"), 2800);
}

function formatSalary(min, max) {
    return max >= 50 ? `₹${min}–50+ LPA` : `₹${min}–${max} LPA`;
}

function daysAgoLabel(days) {
    if (days === 0) return "Posted today";
    if (days === 1) return "Posted yesterday";
    return `Posted ${days} days ago`;
}

/* ================================================================
   4.  SEARCH & FILTER LOGIC
   ================================================================ */

/**
 * Score a job against the current keyword for relevance sorting.
 * Higher score = better match.
 */
function relevanceScore(job, keyword) {
    if (!keyword) return 1;
    const kw = keyword.toLowerCase();
    let score = 0;
    if (job.title.toLowerCase().includes(kw)) score += 10;
    if (job.company.toLowerCase().includes(kw)) score += 5;
    if (job.skills.some(s => s.toLowerCase().includes(kw))) score += 4;
    if (job.description.toLowerCase().includes(kw)) score += 2;
    if (job.location.toLowerCase().includes(kw)) score += 3;
    return score;
}

function filterAndSort() {
    const { keyword, location, jobTypes, experienceLevels, salaryMin, salaryMax, datePosted, sort } = state;

    let results = JOB_DATA.filter(job => {
        // Keyword filter (title, company, skills, description)
        if (keyword) {
            const kw = keyword.toLowerCase();
            const matches =
                job.title.toLowerCase().includes(kw) ||
                job.company.toLowerCase().includes(kw) ||
                job.skills.some(s => s.toLowerCase().includes(kw)) ||
                job.description.toLowerCase().includes(kw) ||
                job.location.toLowerCase().includes(kw);
            if (!matches) return false;
        }

        // Location filter
        if (location) {
            const loc = location.toLowerCase();
            if (!job.location.toLowerCase().includes(loc)) return false;
        }

        // Job type filter
        if (!jobTypes.includes(job.type)) return false;

        // Experience filter
        if (!experienceLevels.includes(job.experience)) return false;

        // Salary filter
        if (job.salaryMax < salaryMin || job.salaryMin > salaryMax) return false;

        // Date posted filter
        if (datePosted !== "any") {
            if (job.postedDaysAgo > parseInt(datePosted, 10)) return false;
        }

        return true;
    });

    // Sort
    switch (sort) {
        case "date-desc":
            results.sort((a, b) => a.postedDaysAgo - b.postedDaysAgo);
            break;
        case "date-asc":
            results.sort((a, b) => b.postedDaysAgo - a.postedDaysAgo);
            break;
        case "salary-desc":
            results.sort((a, b) => b.salaryMax - a.salaryMax);
            break;
        case "salary-asc":
            results.sort((a, b) => a.salaryMin - b.salaryMin);
            break;
        default: // relevance
            results.sort((a, b) => relevanceScore(b, keyword) - relevanceScore(a, keyword));
    }

    return results;
}

/* ================================================================
   5.  RENDER FUNCTIONS
   ================================================================ */

function createJobCard(job, context) {
    const isSaved = state.savedIds.has(job.id);
    const isApplied = state.appliedIds.has(job.id);

    const card = document.createElement("div");
    card.className = "job-card";
    card.dataset.id = job.id;

    card.innerHTML = `
        <div class="job-card-top">
            <div class="company-logo">${job.logo}</div>
            <div class="job-card-info">
                <div class="job-title" data-action="view" data-id="${job.id}">${job.title}</div>
                <div class="company-name">${job.company} &bull; ${job.location}</div>
            </div>
            <div class="job-card-actions">
                <button class="save-btn ${isSaved ? "saved" : ""}" data-action="save" data-id="${job.id}" title="${isSaved ? "Unsave" : "Save"} job">
                    ${isSaved ? "❤️" : "🤍"}
                </button>
            </div>
        </div>

        <div class="job-tags">
            <span class="tag type">${job.type}</span>
            <span class="tag exp">${job.experience}</span>
            <span class="tag salary">${formatSalary(job.salaryMin, job.salaryMax)}</span>
            <span class="tag date">${daysAgoLabel(job.postedDaysAgo)}</span>
        </div>

        <p class="job-description">${job.description}</p>

        <div class="job-tags">
            ${job.skills.slice(0, 5).map(s => `<span class="tag">${s}</span>`).join("")}
        </div>

        <div class="job-card-footer">
            <div style="display:flex;gap:.5rem;">
                <button class="apply-btn ${isApplied ? "applied" : ""}"
                    data-action="apply" data-id="${job.id}"
                    ${isApplied ? "disabled" : ""}>
                    ${isApplied ? "Applied" : "Quick Apply"}
                </button>
                <button class="view-btn" data-action="view" data-id="${job.id}">View Details</button>
            </div>
        </div>
    `;

    // Delegate events on this card
    card.addEventListener("click", e => {
        const btn = e.target.closest("[data-action]");
        if (!btn) return;
        const id = parseInt(btn.dataset.id, 10);
        const job = JOB_DATA.find(j => j.id === id);
        if (!job) return;

        if (btn.dataset.action === "save") toggleSave(job, btn);
        if (btn.dataset.action === "apply") quickApply(job);
        if (btn.dataset.action === "view") openModal(job);
    });

    return card;
}

function renderJobs(jobs) {
    const grid = document.getElementById("jobs-grid");
    const countEl = document.getElementById("results-count");
    grid.innerHTML = "";

    const { page, pageSize } = state;
    const total = jobs.length;
    const totalPages = Math.ceil(total / pageSize);
    const pageJobs = jobs.slice((page - 1) * pageSize, page * pageSize);

    countEl.textContent = total === 0
        ? "No jobs found"
        : `Showing ${(page - 1) * pageSize + 1}–${Math.min(page * pageSize, total)} of ${total} job${total !== 1 ? "s" : ""}`;

    if (pageJobs.length === 0) {
        grid.innerHTML = `<div class="empty-state">
            <span class="empty-icon">🔍</span>
            No jobs match your search. Try different keywords or reset the filters.
        </div>`;
    } else {
        pageJobs.forEach(job => grid.appendChild(createJobCard(job)));
    }

    renderPagination(totalPages);
}

function renderPagination(totalPages) {
    const pag = document.getElementById("pagination");
    pag.innerHTML = "";
    if (totalPages <= 1) return;

    for (let i = 1; i <= totalPages; i++) {
        const btn = document.createElement("button");
        btn.className = `page-btn ${i === state.page ? "active" : ""}`;
        btn.textContent = i;
        btn.addEventListener("click", () => {
            state.page = i;
            runSearch();
            window.scrollTo({ top: 0, behavior: "smooth" });
        });
        pag.appendChild(btn);
    }
}

function renderSavedJobs() {
    const grid = document.getElementById("saved-jobs-grid");
    grid.innerHTML = "";
    const saved = JOB_DATA.filter(j => state.savedIds.has(j.id));
    if (saved.length === 0) {
        grid.innerHTML = `<p class="empty-state"><span class="empty-icon">🤍</span>No saved jobs yet.</p>`;
    } else {
        saved.forEach(job => grid.appendChild(createJobCard(job, "saved")));
    }
}

function renderAppliedJobs() {
    const grid = document.getElementById("applied-jobs-grid");
    grid.innerHTML = "";
    const applied = JOB_DATA.filter(j => state.appliedIds.has(j.id));
    if (applied.length === 0) {
        grid.innerHTML = `<p class="empty-state"><span class="empty-icon">📋</span>No applications yet.</p>`;
    } else {
        applied.forEach(job => grid.appendChild(createJobCard(job, "applied")));
    }
}

/* ================================================================
   6.  ACTIONS
   ================================================================ */

function toggleSave(job, btn) {
    const isDomBtn = btn && typeof btn.classList !== "undefined";
    if (state.savedIds.has(job.id)) {
        state.savedIds.delete(job.id);
        if (isDomBtn) {
            btn.textContent = "🤍";
            btn.classList.remove("saved");
            btn.title = "Save job";
        }
        showToast(`"${job.title}" removed from saved jobs.`);
    } else {
        state.savedIds.add(job.id);
        if (isDomBtn) {
            btn.textContent = "❤️";
            btn.classList.add("saved");
            btn.title = "Unsave job";
        }
        showToast(`"${job.title}" saved! ❤️`);
    }
    persistSaved();
    updateBadges();
    if (state.currentSection === "saved") renderSavedJobs();
}

function quickApply(job) {
    if (state.appliedIds.has(job.id)) return;
    state.appliedIds.add(job.id);
    persistApplied();
    updateBadges();
    showToast(`Application submitted for "${job.title}" at ${job.company} 🎉`);

    // Update all apply buttons for this job on the page
    document.querySelectorAll(`.apply-btn[data-id="${job.id}"]`).forEach(btn => {
        btn.textContent = "Applied";
        btn.classList.add("applied");
        btn.disabled = true;
    });
    if (state.currentSection === "applied") renderAppliedJobs();
}

function updateBadges() {
    document.getElementById("saved-badge").textContent = state.savedIds.size;
    document.getElementById("applied-badge").textContent = state.appliedIds.size;
}

/* ================================================================
   7.  MODAL
   ================================================================ */

function openModal(job) {
    const isApplied = state.appliedIds.has(job.id);
    const isSaved = state.savedIds.has(job.id);

    document.getElementById("modal-body").innerHTML = `
        <div class="modal-company-logo">${job.logo}</div>
        <div class="modal-title">${job.title}</div>
        <div class="modal-company">${job.company} &bull; ${job.location}</div>
        <div class="modal-tags">
            <span class="tag type">${job.type}</span>
            <span class="tag exp">${job.experience}</span>
            <span class="tag salary">${formatSalary(job.salaryMin, job.salaryMax)}</span>
            <span class="tag date">${daysAgoLabel(job.postedDaysAgo)}</span>
        </div>
        <div class="modal-section">
            <h4>About the Role</h4>
            <p>${job.description}</p>
        </div>
        <div class="modal-section">
            <h4>Requirements</h4>
            <ul>${job.requirements.map(r => `<li>${r}</li>`).join("")}</ul>
        </div>
        <div class="modal-section">
            <h4>Skills</h4>
            <div class="job-tags">${job.skills.map(s => `<span class="tag">${s}</span>`).join("")}</div>
        </div>
        <div class="modal-actions">
            <button class="apply-btn ${isApplied ? "applied" : ""}"
                id="modal-apply-btn"
                ${isApplied ? "disabled" : ""}>
                ${isApplied ? "Applied" : "Quick Apply"}
            </button>
            <button class="view-btn" id="modal-save-btn">
                ${isSaved ? "❤️ Saved" : "🤍 Save"}
            </button>
        </div>
    `;

    document.getElementById("modal-apply-btn").addEventListener("click", () => {
        quickApply(job);
        document.getElementById("modal-apply-btn").textContent = "Applied";
        document.getElementById("modal-apply-btn").classList.add("applied");
        document.getElementById("modal-apply-btn").disabled = true;
    });

    document.getElementById("modal-save-btn").addEventListener("click", () => {
        const saveBtn = document.getElementById("modal-save-btn");
        toggleSave(job, saveBtn);
        if (saveBtn) {
            saveBtn.textContent = state.savedIds.has(job.id) ? "❤️ Saved" : "🤍 Save";
        }
    });

    document.getElementById("modal-overlay").style.display = "flex";
}

function closeModal() {
    document.getElementById("modal-overlay").style.display = "none";
}

/* ================================================================
   8.  MAIN SEARCH RUNNER
   ================================================================ */

function runSearch() {
    const results = filterAndSort();
    renderJobs(results);
}

/** Called by debounced auto-search. Shows indicator briefly. */
function autoSearch() {
    if (!state.autoSearch) return;
    const indicator = document.getElementById("autosearch-status");
    indicator.style.display = "flex";
    setTimeout(() => {
        runSearch();
        indicator.style.display = "none";
    }, 300);
}

const debouncedAutoSearch = debounce(autoSearch, 400);

/* ================================================================
   9.  EVENT LISTENERS
   ================================================================ */

function initEventListeners() {
    // Keyword input – auto-search on typing
    const keywordInput = document.getElementById("keyword-input");
    const clearKeyword = document.getElementById("clear-keyword");

    keywordInput.addEventListener("input", () => {
        state.keyword = keywordInput.value.trim();
        clearKeyword.style.display = state.keyword ? "inline" : "none";
        state.page = 1;
        debouncedAutoSearch();
    });
    clearKeyword.addEventListener("click", () => {
        keywordInput.value = "";
        state.keyword = "";
        clearKeyword.style.display = "none";
        state.page = 1;
        debouncedAutoSearch();
    });

    // Location input – auto-search on typing
    const locationInput = document.getElementById("location-input");
    const clearLocation = document.getElementById("clear-location");

    locationInput.addEventListener("input", () => {
        state.location = locationInput.value.trim();
        clearLocation.style.display = state.location ? "inline" : "none";
        state.page = 1;
        debouncedAutoSearch();
    });
    clearLocation.addEventListener("click", () => {
        locationInput.value = "";
        state.location = "";
        clearLocation.style.display = "none";
        state.page = 1;
        debouncedAutoSearch();
    });

    // Search button (instant search, ignores auto-search toggle)
    document.getElementById("search-btn").addEventListener("click", () => {
        state.keyword = keywordInput.value.trim();
        state.location = locationInput.value.trim();
        state.page = 1;
        runSearch();
    });

    // Job-type checkboxes
    document.querySelectorAll("#job-type-filter input[type='checkbox']").forEach(cb => {
        cb.addEventListener("change", () => {
            state.jobTypes = [...document.querySelectorAll("#job-type-filter input:checked")].map(c => c.value);
            state.page = 1;
            debouncedAutoSearch();
        });
    });

    // Experience checkboxes
    document.querySelectorAll("#experience-filter input[type='checkbox']").forEach(cb => {
        cb.addEventListener("change", () => {
            state.experienceLevels = [...document.querySelectorAll("#experience-filter input:checked")].map(c => c.value);
            state.page = 1;
            debouncedAutoSearch();
        });
    });

    // Salary range
    const salaryMinSlider = document.getElementById("salary-min");
    const salaryMaxSlider = document.getElementById("salary-max");
    const salaryMinLabel = document.getElementById("salary-min-label");
    const salaryMaxLabel = document.getElementById("salary-max-label");

    salaryMinSlider.addEventListener("input", () => {
        const val = parseInt(salaryMinSlider.value, 10);
        if (val > state.salaryMax) { salaryMinSlider.value = state.salaryMax; return; }
        state.salaryMin = val;
        salaryMinLabel.textContent = val;
        state.page = 1;
        debouncedAutoSearch();
    });
    salaryMaxSlider.addEventListener("input", () => {
        const val = parseInt(salaryMaxSlider.value, 10);
        if (val < state.salaryMin) { salaryMaxSlider.value = state.salaryMin; return; }
        state.salaryMax = val;
        salaryMaxLabel.textContent = val >= 50 ? "50+" : val;
        state.page = 1;
        debouncedAutoSearch();
    });

    // Date-posted filter
    document.getElementById("date-filter").addEventListener("change", e => {
        state.datePosted = e.target.value;
        state.page = 1;
        debouncedAutoSearch();
    });

    // Sort filter
    document.getElementById("sort-filter").addEventListener("change", e => {
        state.sort = e.target.value;
        state.page = 1;
        runSearch();
    });

    // Reset filters
    document.getElementById("reset-filters").addEventListener("click", resetFilters);

    // Auto-search toggle
    document.getElementById("auto-search-toggle").addEventListener("change", e => {
        state.autoSearch = e.target.checked;
        showToast(`Auto-search ${state.autoSearch ? "enabled ✓" : "disabled"}`);
    });

    // Nav links (section switching)
    document.querySelectorAll(".nav-link").forEach(link => {
        link.addEventListener("click", e => {
            e.preventDefault();
            const section = link.dataset.section;
            switchSection(section);
        });
    });

    // Modal close
    document.getElementById("modal-close").addEventListener("click", closeModal);
    document.getElementById("modal-overlay").addEventListener("click", e => {
        if (e.target === document.getElementById("modal-overlay")) closeModal();
    });
    document.addEventListener("keydown", e => {
        if (e.key === "Escape") closeModal();
    });
}

/* ================================================================
   10.  SECTION SWITCHING
   ================================================================ */

function switchSection(section) {
    state.currentSection = section;
    document.querySelectorAll(".nav-link").forEach(l => l.classList.toggle("active", l.dataset.section === section));

    document.querySelector(".main-content").style.display = section === "search" ? "grid" : "none";
    document.getElementById("saved-section").style.display = section === "saved" ? "block" : "none";
    document.getElementById("applied-section").style.display = section === "applied" ? "block" : "none";

    if (section === "saved") renderSavedJobs();
    if (section === "applied") renderAppliedJobs();
    window.scrollTo({ top: 0, behavior: "smooth" });
}

/* ================================================================
   11.  RESET
   ================================================================ */

function resetFilters() {
    // Checkboxes
    document.querySelectorAll("#job-type-filter input[type='checkbox']").forEach(cb => { cb.checked = true; });
    document.querySelectorAll("#experience-filter input[type='checkbox']").forEach(cb => { cb.checked = true; });

    // Sliders
    document.getElementById("salary-min").value = 0;
    document.getElementById("salary-max").value = 50;
    document.getElementById("salary-min-label").textContent = "0";
    document.getElementById("salary-max-label").textContent = "50+";

    // Selects
    document.getElementById("date-filter").value = "any";
    document.getElementById("sort-filter").value = "relevance";

    // State
    state.jobTypes = ["Full-Time", "Part-Time", "Contract", "Internship", "Remote"];
    state.experienceLevels = ["Entry Level", "Mid Level", "Senior Level", "Lead / Manager"];
    state.salaryMin = 0;
    state.salaryMax = 50;
    state.datePosted = "any";
    state.sort = "relevance";
    state.page = 1;

    runSearch();
    showToast("Filters reset.");
}

/* ================================================================
   12.  INIT
   ================================================================ */

function init() {
    updateBadges();
    initEventListeners();
    runSearch();
}

document.addEventListener("DOMContentLoaded", init);
