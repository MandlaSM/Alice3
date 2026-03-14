* { box-sizing: border-box; }
:root{
  --primary:#4f46e5;
  --primary-dark:#3730a3;
  --bg:#f6f7fb;
  --surface:#ffffff;
  --text:#111827;
  --muted:#6b7280;
  --border:#e5e7eb;
  --header:#101827;
  --success-bg:#ecfdf5;
  --success:#065f46;
  --error-bg:#fef2f2;
  --error:#991b1b;
}
html, body { margin:0; padding:0; }
body {
  font-family: system-ui, -apple-system, Segoe UI, Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif;
  background:var(--bg);
  color:var(--text);
}
a { color:inherit; }
.container { max-width: 1040px; margin: 0 auto; padding: 0 16px; }
.page-shell { padding-top: 18px; padding-bottom: 36px; }
.site-header { background:var(--header); color:#fff; }
.header-inner { display:flex; align-items:center; justify-content:space-between; gap:16px; padding:14px 16px; }
.brand { color:#fff; text-decoration:none; font-weight:700; font-size:18px; letter-spacing:.2px; }
.nav-links { display:flex; align-items:center; gap:12px; flex-wrap:wrap; }
.nav-links a { color:#d7e2ff; text-decoration:none; }
.nav-links a:hover { text-decoration:underline; }
.welcome { color:#d7e2ff; font-size:14px; }
.site-footer { padding: 24px 0 36px; text-align:center; color:var(--muted); }
h1 { font-size: 30px; margin: 10px 0 8px; }
h2 { font-size: 22px; margin: 0 0 6px; }
h3 { font-size: 18px; margin: 10px 0; }
p { line-height:1.55; margin: 0 0 10px; }
.lead { font-size:16px; color:#374151; }
.muted { color:var(--muted); font-size:14px; }
.center-text { text-align:center; }
.card {
  background:var(--surface);
  border:1px solid var(--border);
  border-radius:12px;
  padding:16px;
  box-shadow:0 2px 8px rgba(0,0,0,.05);
}
.hero { padding:22px 20px; }
.hero.compact { padding:18px 18px; }
.grid { display:grid; grid-template-columns:repeat(auto-fill, minmax(280px, 1fr)); gap:14px; }
.row { display:flex; align-items:center; justify-content:space-between; gap:10px; }
.wrap { flex-wrap:wrap; }
.stats-row { display:flex; gap:12px; flex-wrap:wrap; }
.stat.mini { min-width:140px; text-align:center; }
.stat strong { display:block; font-size:28px; }
.stat span { color:var(--muted); font-size:13px; }
.btn {
  background:var(--primary);
  color:#fff;
  border:none;
  border-radius:10px;
  padding:9px 14px;
  text-decoration:none;
  cursor:pointer;
  display:inline-block;
  font:inherit;
}
.btn:hover { filter:brightness(.96); }
.btn.small { padding:7px 11px; font-size:14px; }
.btn.ghost { background:transparent; color:var(--primary); border:1px solid #c7c9ff; }
.inline-form { display:inline; margin:0; }
.pill {
  display:inline-block;
  padding:4px 8px;
  border-radius:999px;
  background:#eef2ff;
  color:var(--primary-dark);
  font-size:12px;
}
.success-pill { background:var(--success-bg); color:var(--success); }
.flash {
  border-radius:10px;
  padding:10px 12px;
  margin:0 0 14px;
}
.flash.success { background:var(--success-bg); color:var(--success); }
.flash.error { background:var(--error-bg); color:var(--error); }
.form label { display:block; margin:10px 0 6px; font-weight:600; }
.form input, .form textarea, .form select {
  width:100%;
  padding:10px;
  border:1px solid #d1d5db;
  border-radius:8px;
  font:inherit;
  background:#fff;
}
.field-error { color:var(--error); font-size:13px; display:block; margin-top:4px; }
.auth-wrap { display:flex; justify-content:center; }
.auth-card { width:min(100%, 720px); }
.progress { height:8px; background:#eef2ff; border-radius:999px; overflow:hidden; margin: 10px 0; }
.progress > span { display:block; height:100%; background:linear-gradient(90deg,var(--primary),#7c3aed); }
.list { list-style:none; margin:0; padding:0; }
.lesson-list li {
  background:#fff;
  padding:12px 14px;
  border:1px solid var(--border);
  border-radius:10px;
  margin-top:10px;
}
.video-wrapper { position:relative; padding-bottom:56.25%; height:0; overflow:hidden; border-radius:12px; background:#000; }
.video-wrapper iframe { position:absolute; top:0; left:0; width:100%; height:100%; border:0; }
.lesson-content p:last-child { margin-bottom:0; }
.course-card, .module-card { min-height: 100%; }
.section-head { margin-bottom:12px; }
.top-gap { margin-top:18px; }
.top-gap-sm { margin-top:10px; }
.mt { margin-top:14px; }
.option-row {
  display:flex;
  align-items:flex-start;
  gap:10px;
  border:1px solid var(--border);
  border-radius:10px;
  padding:12px;
  margin-top:10px;
}
.option-row input { width:auto; margin-top:3px; }
.action-card { text-decoration:none; }
.action-card:hover { border-color:#c7c9ff; }
.admin-actions-grid { grid-template-columns:repeat(auto-fit, minmax(180px, 1fr)); }
.table-clean { width:100%; border-collapse:collapse; }
.table-clean th, .table-clean td { text-align:left; padding:12px 10px; border-bottom:1px solid var(--border); }
.table-clean th { color:#374151; font-size:14px; }
.certificate-shell { margin-top:18px; }
.certificate-card {
  background:#fff;
  border:8px solid #dbe4ff;
  border-radius:18px;
  padding:18px;
  box-shadow:0 2px 10px rgba(0,0,0,.06);
}
.certificate-inner {
  border:2px solid #c7c9ff;
  border-radius:12px;
  padding:32px 22px;
  min-height:420px;
  display:flex;
  flex-direction:column;
  justify-content:center;
}
.certificate-label { text-transform:uppercase; letter-spacing:2px; text-align:center; color:var(--muted); }
.certificate-course { text-align:center; margin:8px 0 12px; }
@media print {
  .site-header, .site-footer, .row .btn, .flash { display:none !important; }
  body { background:#fff; }
  .page-shell { padding:0; }
  .certificate-card { box-shadow:none; border-width:6px; }
}
@media (max-width: 700px) {
  .header-inner { align-items:flex-start; }
  h1 { font-size:26px; }
  .grid { grid-template-columns:1fr; }
  .table-clean { display:block; overflow-x:auto; }
}
